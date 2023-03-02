using BelenHospital.Management.Application.Dtos.SpecialtyDto;

namespace BelenHospital.Management.Application.Interfaces
{
    public interface ISpecialtysApplication
    {
        Task<List<SpecialtyForListDto>> GetSpecialtys();
        Task<SpecialtyDetailDto> GetSpecialty(int id);
        Task InsertSpecialty(SpecialtyForCreateDto specialtyForCreateDto);
        Task UpdateSpecialty(int id, SpecialtyForEditDto specialtyForEditDto);
        Task DeleteSpecialty(int id);
    }
}
