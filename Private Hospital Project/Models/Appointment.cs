using System.ComponentModel.DataAnnotations;

namespace PrivateHospital.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }
      

       // [DataType(DataType.Date)]
        public DateTime AppointmentDate { get; set; }

        //relation
        public virtual Patient Patient { get; set; }
        public virtual Doctor Doctor { get; set; }
        
    }
}
