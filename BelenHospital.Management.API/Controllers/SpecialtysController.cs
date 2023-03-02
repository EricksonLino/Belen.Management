using BelenHospital.Management.Application.Dtos;
using BelenHospital.Management.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BelenHospital.Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtysController : ControllerBase
    {
        private readonly ISpecialtysApplication specialtysApplication;

        public SpecialtysController(ISpecialtysApplication specialtysApplication)
        {
            this.specialtysApplication = specialtysApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<SpecialtyForListDto>>> GetAll()
        {
            var specialtys = await specialtysApplication.GetSpecialtys();
            return specialtys;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SpecialtyDetailDto>> GetById(int id)
        {
            var specialty = await specialtysApplication.GetSpecialty(id);
            return specialty;
        }

        [HttpPost]
        public async Task<ActionResult> Insert([FromBody] SpecialtyForCreateDto specialtyForCreateDto)
        {
            await specialtysApplication.InsertSpecialty(specialtyForCreateDto);
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Update(int id, [FromBody] SpecialtyForEditDto specialtyForEditDto)
        {
            await specialtysApplication.UpdateSpecialty(id, specialtyForEditDto);
            return Ok();
        }
    }
}
