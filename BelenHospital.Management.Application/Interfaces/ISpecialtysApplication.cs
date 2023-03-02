using BelenHospital.Management.Application.Dtos;

namespace BelenHospital.Management.Application.Interfaces
{
    public interface ISpecialtysApplication
    {
        Task<List<SpecialtyForListDto>> GetSpecialtys();
        Task<SpecialtyDetailDto> GetSpecialty(int id);
    }
}
