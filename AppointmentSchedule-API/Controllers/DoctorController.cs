using AppointmentSchedule.Model.Model;
using AppointmentSchedule.Service.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentSchedule_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var doctors = await _doctorService.GetAllAsync();
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var doctor = await _doctorService.GetByIdAsync(id);
            if (doctor == null) return NotFound();
            return Ok(doctor);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Doctor doctor)
        {
            await _doctorService.AddAsync(doctor);
            return CreatedAtAction(nameof(GetById), new { id = doctor.Id }, doctor);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Doctor doctor)
        {
            if (id != doctor.Id) return BadRequest();

            await _doctorService.UpdateAsync(doctor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _doctorService.DeleteAsync(id);
            return NoContent();
        }
    }
}
