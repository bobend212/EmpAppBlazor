namespace EmpAppBlazor.Client.Services.ProjectService
{
    public interface IProjectServiceClient
    {
        List<ProjectGetDTO> Projects { get; set; }

        Task GetProjects();

        Task<ServiceResponse<ProjectGetDTO>> GetSingleProject(int projectId);

        Task CreateProject(ProjectGetDTO project);

        Task UpdateProject(ProjectGetDTO project);

        Task DeleteProject(int projectId);
    }
}