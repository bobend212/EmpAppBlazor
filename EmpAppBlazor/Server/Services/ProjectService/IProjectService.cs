using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server.Services.ProjectService
{
    public interface IProjectService
    {
        Task<ServiceResponse<List<ProjectGetDTO>>> GetProjects();

        Task<ServiceResponse<List<ProjectGetDTO>>> GetProjectsByWorkloadStage(string stageWorkload);

        Task<ServiceResponse<ProjectGetDTO>> GetSingleProject(int projectId);

        Task<ServiceResponse<bool>> CreateProject(ProjectAddDTO project);

        Task<ServiceResponse<bool>> UpdateProject(ProjectUpdateDTO project);

        Task<ServiceResponse<bool>> DeleteProject(int projectId);
    }
}