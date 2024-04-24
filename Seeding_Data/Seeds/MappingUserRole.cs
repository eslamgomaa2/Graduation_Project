using Microsoft.AspNetCore.Identity;
using OA.Domain.Enum;
using System.Collections.Generic;

namespace OA.Persistence.Seeds
{
    public static class MappingUserRole
    {
        public static IdentityUserRole<string> IdentityUserRole { get; } =
        
             new IdentityUserRole<string>()
            {
               
               
                    RoleId = "8414c5cb - f27b - 42bb - 93c5 - c11425637ae3",
                    UserId = "cacb7495-b880-4007-8578-beb775b0904e"


             };
        
    }
}
