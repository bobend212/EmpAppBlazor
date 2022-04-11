namespace EmpAppBlazor.Client.Services.ProjectService
{
    public interface IProjectService
    {
        List<Project> Projects { get; set; }

        Task GetProjects();

        Task<ServiceResponse<Project>> GetProject(int projectId);

        Task<Project> CreateProject(Project project);

        Task<Project> UpdateProject(Project project);

        Task DeleteProject(int projectId);
    }
}