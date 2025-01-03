using AppointmentSchedule.Domain.Model;
using AppointmentSchedule.Infra.Context;
using AppointmentSchedule.Infra.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppointmentSchedule.Infra.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppointmentScheduleContext _context;

        public DoctorRepository(AppointmentScheduleContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        public async Task AddAsync(Doctor doctor)
        {
            await _context.Doctors.AddAsync(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
