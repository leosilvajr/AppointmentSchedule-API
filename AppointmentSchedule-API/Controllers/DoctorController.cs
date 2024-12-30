using AppointmentSchedule.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AppointmentSchedule_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctorController : ControllerBase
    {
        [HttpGet]
        public List<Doctor> Index()
        {
            var lista = new List<Doctor>();
            lista.Add(new Doctor(1 , "João", "Cardiologista", "M"));
            lista.Add(new Doctor(2, "Maria", "Dermatologista", "F"));
            lista.Add(new Doctor(3, "Pedro", "Ortopedista", "M"));
            lista.Add(new Doctor(4, "Ana", "Oftalmologista", "F"));
            lista.Add(new Doctor(5, "Lucas", "Ginecologista", "M"));

            return lista;
        }
    }
}
