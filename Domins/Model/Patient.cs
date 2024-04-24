using OA.Domain.Auth;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domins.Model
{
    public class Patient
    {
        


            [Key]
            public int Id { get; set; }


            [MaxLength(100)]
            public string Name { get; set; }


            public decimal HeartRate { get; set; }
            public decimal OxygenRate { get; set; }


            [ForeignKey("User")]
            public string UserId { get; set; }


            public ApplicationUser User { get; set; }


            [ForeignKey("Doctor")]
            public int DoctorId { get; set; }


            public virtual Doctor? Doctor { get; set; }
            public virtual List<Alarm>? alarms { get; set; }



     }
}  



