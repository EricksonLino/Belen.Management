using AutoMapper;
using BelenHospital.Management.Application.Dtos.SpecialtyDto;
using BelenHospital.Management.Application.Interfaces;
using BelenHospital.Management.Entity;
using BelenHospital.Management.Repository.Interfaces;

namespace BelenHospital.Management.Application.Implementations
{
    public class SpecialtysApplication : ISpecialtysApplication
    {
        private readonly ISpecialtysRepository specialtysRepository;
        private readonly IMapper mapper;

        public SpecialtysApplication(ISpecialtysRepository specialtysRepository, IMapper mapper)
        {
            this.specialtysRepository = specialtysRepository;
            this.mapper = mapper;
        }
        public async Task<List<SpecialtyForListDto>> GetSpecialtys()
        {
            var specialtys = await specialtysRepository.GetSpecialtys();
            var specialtysDto = mapper.Map<List<SpecialtyForListDto>>(specialtys);

            return specialtysDto;
        }
        public async Task<SpecialtyDetailDto> GetSpecialty(int id)
        {
            var specialty = await specialtysRepository.GetSpecialty(id);
            var specialtyDto = mapper.Map<SpecialtyDetailDto>(specialty);

            return specialtyDto;
        }

        public async Task InsertSpecialty(SpecialtyForCreateDto specialtyForCreateDto)
        {
            var specialtyEntity = mapper.Map<Specialty>(specialtyForCreateDto);

            await specialtysRepository.InsertSpecialty(specialtyEntity);

        }

        public async Task UpdateSpecialty(int id, SpecialtyForEditDto specialtyForEditDto)
        {
            var specialtyEntity = await specialtysRepository.GetSpecialty(id);
            mapper.Map(specialtyForEditDto, specialtyEntity);

            await specialtysRepository.UpdateSpecialty(specialtyEntity);
        }

        public async Task DeleteSpecialty(int id)
        {
            var specialtyEntity = await specialtysRepository.GetSpecialty(id);
            await specialtysRepository.DeleteSpecialty(specialtyEntity);

        }
    }
}
