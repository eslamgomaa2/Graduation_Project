using Domins.Model;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.Interfaces;

namespace Graduation_Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class PatientController : ControllerBase
    {
        private readonly IBaseRepository<Patient> _baserepository;

        public PatientController(IBaseRepository<Patient> baserepository)
        {
            _baserepository = baserepository;
        }

        [HttpGet("GetAllPatient")]
        public async Task<ActionResult> GetAllpatient()
        {
            var data=await _baserepository.GetAllAsync();
            return Ok(data.Select(o => new {o.Id,o.FName,o.LName,o.UserName,o.DoctorId,o.UserId }));
        }

    }
}
