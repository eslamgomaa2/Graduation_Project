using Domins.Dtos.Dto;
using Domins.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OA.Domain.Auth;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class AdminService : BaseRepositry<Doctor>, IAdminService
    {
        private readonly ApplicationDbcontext _dbcontext;
        private readonly UserManager<ApplicationUser> _userManager;


        public AdminService(ApplicationDbcontext dbcontext, UserManager<ApplicationUser> userManager) : base(dbcontext)
        {
            _userManager = userManager;
            _dbcontext = dbcontext;
        }
        public async Task<bool> Deletedoctor(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            
            if (user == null )
                return false;
           
            
            var result = await _userManager.DeleteAsync(user);


            return result.Succeeded;

        }



        public async Task<RegisterAsDoctorRequest> updatedoctor(RegisterAsDoctorRequest model, string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            var sameuser = await _dbcontext.Doctors.SingleOrDefaultAsync(o => o.UserId == id);

            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.UserName = model.UserName;
            user.PhoneNumber = model.phoneNumber;
            await _userManager.UpdateAsync(user);
            sameuser.UserName = model.UserName;
            _dbcontext.Doctors.Update(sameuser);
            _dbcontext.SaveChanges();
            return model;

        }
      


    }
}

