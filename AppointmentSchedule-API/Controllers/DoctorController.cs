using AppointmentSchedule.Model.Model;
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
            return lista;
        }
    }
}
