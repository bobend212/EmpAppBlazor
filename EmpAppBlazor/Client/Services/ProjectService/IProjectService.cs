using EmpAppBlazor.Shared;

namespace EmpAppBlazor.Client.Services.ProjectService
{
    public interface IProjectService
    {
        List<Project> Projects { get; set; }
        Task GetProjects();
        Task<ServiceResponse<Project>> GetProject(int projectId);
    }
}
