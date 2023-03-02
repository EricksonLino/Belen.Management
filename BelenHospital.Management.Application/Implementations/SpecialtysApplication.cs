using AutoMapper;
using BelenHospital.Management.Application.Dtos;
using BelenHospital.Management.Application.Interfaces;
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

        
    }
}
