using AutoMapper;
using BelenHospital.Management.Application.Dtos.PatientDto;
using BelenHospital.Management.Application.Dtos.SpecialtyDto;
using BelenHospital.Management.Entity;

namespace BelenHospital.Management.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Patient, PatientForListDto>();
            CreateMap<Patient, PatientDetailDto>();
            CreateMap<PatientForCreateDto, Patient>().ReverseMap();
            CreateMap<PatientForEditDto, Patient>().ReverseMap();

            CreateMap<Specialty, SpecialtyForListDto>();
            CreateMap<Specialty, SpecialtyDetailDto>();
            CreateMap<SpecialtyForCreateDto, Specialty>().ReverseMap();
            CreateMap<SpecialtyForEditDto, Specialty>().ReverseMap();
        }
    }
}
