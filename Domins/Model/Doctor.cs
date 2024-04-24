using OA.Domain.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domins.Model
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }




        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public virtual List<Patient>? Patients { get; set; }
        
    }
}
