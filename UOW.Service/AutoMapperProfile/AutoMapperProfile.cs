using AutoMapper;
using UOW.Core.Entities;
using UOW.Service.DTO;

namespace UOW.Service.AutoMapperProfile;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ProjectDTO, Project>().ReverseMap();
    }
}