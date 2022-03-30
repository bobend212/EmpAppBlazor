namespace EmpAppBlazor.Server.Services.ProjectService
{
    public interface IProjectService
    {
        Task<ServiceResponse<List<Project>>> GetProjectsAsync();
    }
}
