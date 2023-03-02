﻿using BelenHospital.Management.Application.Dtos;
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
    }
}