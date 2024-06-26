﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace OA.Domain.Auth
{
    public class AuthenticationResponse
    {
       public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public  List<string> Roles { get; set; }
        public bool IsAuthenticated { get; set; }
       
        public string JWToken { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiration { get; set; }
        public string Message { get; set; }
        
    }
}
