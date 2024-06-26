using System.ComponentModel.DataAnnotations;
namespace Domins.Dtos.Dto
{
    public class PatinetDestinationDto
    {

        [MaxLength(100)]
        public string Name { get; set; }

    }
}
