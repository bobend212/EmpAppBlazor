using AutoMapper;
using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Project
            CreateMap<Project, ProjectGetDTO>()
                .ForMember(dto => dto.Designers, c => c.MapFrom(c => c.UserProjects.Select(x => x.User)));
            CreateMap<ProjectAddDTO, Project>();
            CreateMap<Project, ProjectUpdateDTO>();

            //Workload
            CreateMap<Workload, WorkloadGetDTO>();
            CreateMap<WorkloadAddDTO, Workload>();
            CreateMap<Workload, WorkloadUpdateDTO>();

            //TaskItem
            CreateMap<TaskItemToEditStatusDTO, TaskItem>();
            CreateMap<TaskItem, TaskItemGetDTO>();
            CreateMap<TaskItemAddDTO, TaskItem>();
            CreateMap<TaskItem, TaskItemUpdateDTO>();



            CreateMap<User, UserDTO>();
            CreateMap<UserUpdateDTO, User>();
        }
    }
}