using BelenHospital.Management.Application.Dtos;
using BelenHospital.Management.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BelenHospital.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientsApplication patientsApplication;

        public PatientsController(IPatientsApplication patientsApplication)
        {
            this.patientsApplication = patientsApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<PatientForListDto>>> GetAll()
        {
            var patients = await patientsApplication.GetPatients();
            return patients;
        }

        [HttpGet("{id:int}")]

        public async Task<ActionResult<PatientDetailDto>> GetById(int id)
        {
            var patient = await patientsApplication.GetPatient(id);
            return patient;
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] PatientForCreateDto patientForCreateDto)
        {
            await patientsApplication.InsertPatient(patientForCreateDto);
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody] PatientForEditDto patientForEditDto)
        {
            await patientsApplication.UpdatePatient(id, patientForEditDto);
            return Ok();
        }
    }
}
