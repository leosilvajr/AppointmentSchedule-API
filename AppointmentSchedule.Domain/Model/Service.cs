using System.ComponentModel.DataAnnotations;

namespace AppointmentSchedule.Domain.Model
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public ICollection<DoctorService> DoctorServices { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
