using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server.Services.ProjectService
{
    public interface IProjectService
    {
        Task<ServiceResponse<List<ProjectDTO>>> GetProjectsAsync();

        Task<ServiceResponse<Project>> GetProjectAsync(int projectId);

        Task<ServiceResponse<List<Project>>> GetProjectsByWorkloadStage(string stageWorkload);

        Task<ServiceResponse<Project>> CreateProject(Project project);

        Task<ServiceResponse<Project>> UpdateProject(Project project);

        Task<ServiceResponse<bool>> DeleteProject(int projectId);
    }
}