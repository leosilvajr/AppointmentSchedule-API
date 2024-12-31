using AppointmentSchedule.Model.Model;
using AppointmentSchedule.Repository.Repository.Interfaces;
using AppointmentSchedule.Service.Services.Interfaces;

namespace AppointmentSchedule.Service.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            return await _doctorRepository.GetAllAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return await _doctorRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Doctor doctor)
        {
            await _doctorRepository.AddAsync(doctor);
        }

        public async Task UpdateAsync(Doctor doctor)
        {
            await _doctorRepository.UpdateAsync(doctor);
        }

        public async Task DeleteAsync(int id)
        {
            await _doctorRepository.DeleteAsync(id);
        }
    }
}
