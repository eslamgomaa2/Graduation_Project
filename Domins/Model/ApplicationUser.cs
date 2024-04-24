﻿
using Domins.Model;
using Microsoft.AspNetCore.Identity;

namespace OA.Domain.Auth
{
    public class ApplicationUser : IdentityUser
    {
        
        
        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }
       
        public List<RefreshToken>? RefreshTokens { get; set; }
        
        
        public bool OwnsToken(string token)
        {
            return this.RefreshTokens?.Find(x => x.Token == token) != null;
        }
    }
}