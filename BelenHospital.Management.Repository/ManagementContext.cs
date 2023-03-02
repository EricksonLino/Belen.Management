using BelenHospital.Management.Entity;
using Microsoft.EntityFrameworkCore;

namespace BelenHospital.Management.Repository
{
    public class ManagementContext : DbContext
    {
        public ManagementContext(DbContextOptions<ManagementContext> options) : base(options) 
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Specialty> Specialtys { get; set; }
    }
}
