/*using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OA.Domain.Auth;

namespace Seeding_Data.Seeds
{
    public  class seedingAdmin
    {
      

       

        public  async  void DefaultAdmin(UserManager<ApplicationUser> _userManager, RoleManager<IdentityRole> _RoleManager)
        {
            
           if (!await _RoleManager.RoleExistsAsync("Admin"))
            {
               var Role= await _RoleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (await _userManager.FindByEmailAsync("Admin@gmail.com")==null)
            {
                var user=new ApplicationUser
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    UserName = "Admin",
                    Email = "Admin@gmail.com",
                    PhoneNumber = 012152001.ToString(),
                   
                };
              var result =await  _userManager.CreateAsync(user, 0134456.ToString());
                if(result.Succeeded)
                {
                   await _userManager.AddToRoleAsync(user,"Admin");
                }
            }


        }
       




}
}
*/