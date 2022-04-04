namespace EmpAppBlazor.Server.Services.ProjectService
{
    public interface IProjectService
    {
        Task<ServiceResponse<List<Project>>> GetProjectsAsync();
        Task<ServiceResponse<Project>> GetProjectAsync(int projectId);

        Task<ServiceResponse<List<Project>>> GetProjectsByWorkloadStage(string stageWorkload);
    }
}
