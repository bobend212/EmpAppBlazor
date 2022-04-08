using AutoMapper;
using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Project, ProjectDTO>()
                .ForMember(dto => dto.Designers, c => c.MapFrom(c => c.Designers));
            CreateMap<User, UserDTO>();
            CreateMap<Workload, WorkloadDTO>();
        }
    }
}
