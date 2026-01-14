using System.ComponentModel.DataAnnotations;

namespace PrivateHospital.Models
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public int Age { get; set; }

        public string Address { get; set; }

        public DateTime RegisteredDate { get; set; } // DateTime.Now;
    }
    public enum Gender
    {
        male,
        Female,
        Others
    }
}
