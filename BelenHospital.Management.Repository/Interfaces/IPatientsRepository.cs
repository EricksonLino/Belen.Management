using BelenHospital.Management.Entity;

namespace BelenHospital.Management.Repository.Interfaces
{
    public interface IPatientsRepository
    {
        Task<List<Patient>> GetPatients();
        Task<Patient> GetPatient(int id);
        Task InsertPatient(Patient patient);
        Task UpdatePatient(Patient patient);
    }
}
