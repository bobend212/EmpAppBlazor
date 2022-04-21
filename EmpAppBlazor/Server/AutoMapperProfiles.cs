using AutoMapper;
using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Project, ProjectGetDTO>()
                .ForMember(dto => dto.Designers, c => c.MapFrom(c => c.Designers));

            CreateMap<ProjectAddDTO, Project>();
            CreateMap<Project, ProjectUpdateDTO>();


            CreateMap<User, UserDTO>();
            CreateMap<UserUpdateDTO, User>();
            CreateMap<Workload, WorkloadDTO>();
            CreateMap<TaskItemToEditStatusDTO, TaskItem>();
        }
    }
}