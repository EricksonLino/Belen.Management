using BelenHospital.Management.Application.Dtos.PatientDto;

namespace BelenHospital.Management.Application.Interfaces
{
    public interface IPatientsApplication
    {
        Task<List<PatientForListDto>> GetPatients();
        Task<PatientDetailDto> GetPatient(int id);
        Task InsertPatient(PatientForCreateDto patientForCreateDto);
        Task UpdatePatient(int id, PatientForEditDto patientForEditDto);
        Task DeletePatient(int id);
    }
}
