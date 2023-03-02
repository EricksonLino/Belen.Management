using BelenHospital.Management.Application.Dtos;

namespace BelenHospital.Management.Application.Interfaces
{
    public interface IPatientsApplication
    {
        Task<List<PatientForListDto>> GetPatients();
        Task<PatientDetailDto> GetPatient(int id);
    }
}
