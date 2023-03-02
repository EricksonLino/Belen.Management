using BelenHospital.Management.Entity;

namespace BelenHospital.Management.Repository.Interfaces
{
    public interface ISpecialtysRepository
    {
        Task<List<Specialty>> GetSpecialtys();
        Task<Specialty> GetSpecialty(int id);
        Task InsertSpecialty(Specialty specialty);
        Task UpdateSpecialty(Specialty specialty);
    }
}
