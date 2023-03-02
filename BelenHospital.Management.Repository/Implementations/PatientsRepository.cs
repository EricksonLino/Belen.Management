﻿using BelenHospital.Management.Entity;
using BelenHospital.Management.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BelenHospital.Management.Repository.Implementations
{
    public class PatientsRepository : IPatientsRepository
    {
        private readonly ManagementContext context;
        public PatientsRepository(ManagementContext context)
        {
            this.context = context;
        }
        public async Task<List<Patient>> GetPatients()
        {
            var patients = await context.Patients.ToListAsync();
            return patients;
        }
        public async Task<Patient> GetPatient(int id)
        {
            var patient = await context.Patients.SingleOrDefaultAsync(p => p.Id == id);
            return patient;
        }

        
    }
}