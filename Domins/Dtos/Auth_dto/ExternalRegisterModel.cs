using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domins.Dtos.Auth_dto
{
    public class ExternalRegisterModel
    {
        public string Email { get; set; }
        public string Provider { get; set; }
        public string ProviderKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        // Additional fields as needed
    }
}
