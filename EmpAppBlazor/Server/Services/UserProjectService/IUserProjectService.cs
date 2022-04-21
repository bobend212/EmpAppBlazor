namespace EmpAppBlazor.Server.Services.UserProjectService
{
    public interface IUserProjectService
    {
        Task<ServiceResponse<ProjectGetDTO>> AddUserProject(UserProjectAddDTO model);
    }
}
