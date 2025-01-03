using AppointmentSchedule.Domain.Model;

namespace AppointmentSchedule.Application.Services.Interfaces
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetAllAsync();
        Task<Doctor> GetByIdAsync(int id);
        Task AddAsync(Doctor doctor);
        Task UpdateAsync(Doctor doctor);
        Task DeleteAsync(int id);
    }
}
