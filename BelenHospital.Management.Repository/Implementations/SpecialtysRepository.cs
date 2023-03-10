using BelenHospital.Management.Entity;
using BelenHospital.Management.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BelenHospital.Management.Repository.Implementations
{
    public class SpecialtysRepository : ISpecialtysRepository
    {
        private readonly ManagementContext context;

        public SpecialtysRepository(ManagementContext context)
        {
            this.context = context;
        }
        public async Task<List<Specialty>> GetSpecialtys()
        {
            var specialtys = await context.Specialtys.ToListAsync();
            return specialtys;
        }
        public async Task<Specialty> GetSpecialty(int id)
        {
            var specialty = await context.Specialtys.SingleOrDefaultAsync(x => x.Id == id);
            return specialty;
        }

        public async Task InsertSpecialty(Specialty specialty)
        {
            context.Specialtys.Add(specialty);
            await context.SaveChangesAsync();
        }

        public async Task UpdateSpecialty(Specialty specialty)
        {
            context.Specialtys.Update(specialty);
            await context.SaveChangesAsync();
        }

        public async Task DeleteSpecialty(Specialty specialty)
        {
            context.Specialtys.Remove(specialty);
            await context.SaveChangesAsync();


        }
    }
}
