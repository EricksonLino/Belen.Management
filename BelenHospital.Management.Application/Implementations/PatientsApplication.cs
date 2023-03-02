using AutoMapper;
using BelenHospital.Management.Application.Dtos;
using BelenHospital.Management.Application.Interfaces;
using BelenHospital.Management.Entity;
using BelenHospital.Management.Repository.Interfaces;

namespace BelenHospital.Management.Application.Implementations
{
    public class PatientsApplication : IPatientsApplication
    {
        private readonly IPatientsRepository patientsRepository;
        private readonly IMapper mapper;

        public PatientsApplication(IPatientsRepository patientsRepository, IMapper mapper )
        {
            this.patientsRepository = patientsRepository;
            this.mapper = mapper;
        }

        public async Task<List<PatientForListDto>> GetPatients()
        {
            var patients = await patientsRepository.GetPatients();

            var patientsDto = mapper.Map<List<PatientForListDto>>(patients);
            return patientsDto;
        }
        public async Task<PatientDetailDto> GetPatient(int id)
        {
            var patient = await patientsRepository.GetPatient(id);

            var patientDto = mapper.Map<PatientDetailDto>(patient);
            return patientDto;
        }

        public async Task InsertPatient(PatientForCreateDto patientForCreateDto)
        {
            var patientEntity = mapper.Map<Patient>(patientForCreateDto);
            await patientsRepository.InsertPatient(patientEntity);
        }

        public async Task UpdatePatient(int id, PatientForEditDto patientForEditDto)
        {
            var patientEntity = await patientsRepository.GetPatient(id);
            mapper.Map(patientForEditDto, patientEntity);

            await patientsRepository.UpdatePatient(patientEntity);
        }

        public async Task DeletePatient(int id)
        {
            var patientEntity = await patientsRepository.GetPatient(id);
            await patientsRepository.DeletePatient(patientEntity);
        }
    }
}
