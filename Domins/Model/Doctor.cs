﻿using OA.Domain.Auth;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domins.Model
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string FName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LName { get; set; }
        [Required]
        [MaxLength(100)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }



        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser? ApplicationUser { get; set; }
        public virtual List<Patient>? Patients { get; set; }

    }
}
