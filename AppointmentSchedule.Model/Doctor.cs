namespace AppointmentSchedule.Model
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string Icon { get; set; }

        public Doctor()
        {
            
        }
        public Doctor(int id, string name, string specialty, string icon)
        {
            Id = id;
            Name = name;
            Specialty = specialty;
            Icon = icon;
        }

    }
}
