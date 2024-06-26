/*using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OA.Domain.Auth;

namespace Seeding_Data.Seeds
{
    public static class SeedingAdmin
    {
        public static ApplicationUser GetDefaultAdminUser()
        {
            return new ApplicationUser
            {
                Id = "1", 
                FirstName = "Admin",
                LastName = "Admin",
                UserName = "Admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "Admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null,"102030"),
                EmailConfirmed = true,
                PhoneNumber = "012152001",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };
        }
    }
}
*/