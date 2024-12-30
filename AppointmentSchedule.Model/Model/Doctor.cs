using System.ComponentModel.DataAnnotations;

namespace AppointmentSchedule.Model.Model
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Specialty { get; set; }

        [StringLength(10)]
        public string Icon { get; set; }

        public ICollection<DoctorService> DoctorServices { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
    }
}
