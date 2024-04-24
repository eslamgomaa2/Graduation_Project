using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domins.Model
{
    public class Alarm
    {
        [Key]
       public int id { get; set; }
        public string? AlarmMessage { get; set; }
        public DateTime TimeStamp { get; set; }

        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
        
       
    }
}
