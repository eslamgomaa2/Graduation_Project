using Domins.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OA.Domain.Auth;
using Repository;
using Repository.Interfaces;
using System.Net.Http;
using System.Security.Claims;

namespace Graduation_Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class PatientController : ControllerBase
    {
        private readonly IBaseRepository<Patient> _baseRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbcontext _dbcontext;
        private readonly IHttpContextAccessor _httpContextAccessor;




        public PatientController(IBaseRepository<Patient> baseRepository, UserManager<ApplicationUser> userManager, ApplicationDbcontext dbcontext, IHttpContextAccessor httpContextAccessor)
        {
            _baseRepository = baseRepository;
            _userManager = userManager;
            _dbcontext = dbcontext;
            _httpContextAccessor = httpContextAccessor;
        }
      
    }
}
