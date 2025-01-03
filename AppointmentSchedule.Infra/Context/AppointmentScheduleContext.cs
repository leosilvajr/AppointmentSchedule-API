using AppointmentSchedule.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace AppointmentSchedule.Infra.Context
{
    public class AppointmentScheduleContext : DbContext
    {
        public AppointmentScheduleContext(DbContextOptions<AppointmentScheduleContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<DoctorService> DoctorServices { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorService>()
                .HasOne(ds => ds.Doctor)
                .WithMany(d => d.DoctorServices)
                .HasForeignKey(ds => ds.DoctorId);

            modelBuilder.Entity<DoctorService>()
                .HasOne(ds => ds.Service)
                .WithMany(s => s.DoctorServices)
                .HasForeignKey(ds => ds.ServiceId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Service)
                .WithMany(s => s.Appointments)
                .HasForeignKey(a => a.ServiceId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.User)
                .WithMany(u => u.Appointments)
                .HasForeignKey(a => a.UserId);
        }
    }
}
