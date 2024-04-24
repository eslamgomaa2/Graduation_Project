
using Domins.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OA.Domain.Auth;

namespace Repository
{
    public class ApplicationDbcontext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbcontext(DbContextOptions options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = true;
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Alarm>Alarms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);



            modelBuilder.HasDefaultSchema("Identity");


            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles");
                entity.HasData(DefaultRoles.MyRole);
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
            
                entity.ToTable(name: "Users");
                entity.HasData(
            new ApplicationUser
            {
                Id = "1", 
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
                Email = "admin@example.com",
                NormalizedEmail = "ADMIN@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = 1254515156.ToString(),
                SecurityStamp = string.Empty



            });

                modelBuilder.Entity<IdentityUserRole<string>>(entity =>
                {

                    entity.ToTable("UserRoles");

                    entity.HasData(new IdentityUserRole<string> { RoleId = "1", UserId = "1" });


                });
                modelBuilder.Entity<Patient>(entity =>
                {
                    
                    
                });

               

                modelBuilder.Entity<Doctor>(entity =>
                {
                   
                  
                });
               
                modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
                {
                  
                    entity.ToTable("UserClaims");
                });

                modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
                {
                  
                    entity.HasKey(o => o.UserId);

                    entity.ToTable("UserLogins");
                });

                modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
                {
                  
                    entity.ToTable("RoleClaims");
                });

                modelBuilder.Entity<IdentityUserToken<string>>(entity =>
                {
                   
                    entity.ToTable("UserTokens");
                });






            });
        }

    }
}