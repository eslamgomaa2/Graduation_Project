using Azure;
using Domins.Dtos.Auth_dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OA.Domain.Auth;
using Repository.Implementation;
using Repository.Interfaces;
using System.Security.Claims;

namespace Graduation_Project.Api.Controllers
{
    [Route("api/[Controller]/")]
    [ApiController]
    public class AccountServiceController : Controller
    {
        private readonly IAccountServices _accountServices;

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountServiceController(IAccountServices accountServices, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _accountServices = accountServices;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] AuthenticationRequest model)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            var result = await _accountServices.Login(model);
            if (!result.IsAuthenticated)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterAsPatientRequest model)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            var res = await _accountServices.RegisterAsPatientAsync(model);
            if (!res.IsAuthenticated)
                return BadRequest(res.Message);

            return Ok(res);
        }

        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword([FromBody] ForgotPasswordRequest model)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            await _accountServices.ForgotPassword(model);
            return Ok();
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest model)
        {
            await _accountServices.ResetPassword(model);
            return Ok();
        }



        [HttpPost("external_login")]
        public async Task<IActionResult> ExternalLogin(ExternalLoginModel model)
        {
            // Authenticate the user with the external provider
            var externalLoginInfo = await _signInManager.GetExternalLoginInfoAsync();

            if (externalLoginInfo == null)
            {
                // Handle error: External login information not found
                return BadRequest(new { error = "External login information not found." });
            }

            // Sign in the user with the external provider
            var signInResult = await _signInManager.ExternalLoginSignInAsync(externalLoginInfo.LoginProvider, externalLoginInfo.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            if (!signInResult.Succeeded)
            {
                var email = User.Claims.FirstOrDefault(o => o.Type == ClaimTypes.Email)?.Value;
                if (email!=null)
                {
                    var user = await _userManager.FindByEmailAsync(email);
                    if (user == null)
                    {
                        var newUser = new ApplicationUser
                        {
                            UserName = User.Claims.FirstOrDefault(o => o.Type == ClaimTypes.Name)?.Value,
                            Email = email
                        };

                        var createUserResult = await _userManager.CreateAsync(newUser);

                        if (!createUserResult.Succeeded)
                        {
                            // Handle user creation failure
                            return BadRequest(new { error = "Failed to create user." });
                        }

                        user = newUser;
                    }

                    var addLoginResult = await _userManager.AddLoginAsync(user, externalLoginInfo);

                    if (!addLoginResult.Succeeded)
                    {
                        // Handle adding external login failure
                        return BadRequest(new { error = "Failed to add external login to user." });
                    }

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return Ok("Account created or authenticated successfully.");
                }
            }

            // Authentication successful, return success response
            return Ok("Authentication successful!");
        }


        [HttpPost("External Register")]
        public async Task<IActionResult> ExternalRegister(ExternalRegisterModel model)
        {
            var existuser =await _userManager.FindByEmailAsync(model.Email);
            if (existuser != null)
            {
                return BadRequest("this email is already exist");
            }
            // Create a new ApplicationUser instance
            var user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserName = model.Username,
                Email = model.Email
            };

            // Create the user in the database
            var result = await _userManager.CreateAsync(user);

            if (!result.Succeeded)
            {
                return BadRequest("User creation failed.");
            }

            // If user creation is successful, add external login to the user
            var externalLoginInfo = new ExternalLoginInfo(null, model.Provider, model.ProviderKey, model.Provider);

            var externalLoginResult = await _userManager.AddLoginAsync(user, externalLoginInfo);

            if (!externalLoginResult.Succeeded)
            {
                // Handle error: Adding external login failed
                return BadRequest("Adding external login failed.");

            }
            // User created and linked with external provider, return success response
            return Ok("User created and linked with external provider!");
        }



        /* public void SetRefreshTokenInCookies(string refreshToken, DateTime expiration)
         {
             var cookieOptions = new CookieOptions
             {
                 Expires = expiration,
                 HttpOnly = true
             };

             Response.Cookies.Append("RefreshToken", refreshToken, cookieOptions);
         }*/
    }

}
