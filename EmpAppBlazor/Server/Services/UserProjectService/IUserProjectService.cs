namespace EmpAppBlazor.Server.Services.UserProjectService
{
    public interface IUserProjectService
    {
        Task<ServiceResponse<bool>> AddUserProject(UserProjectAddRemoveDTO model);
        Task<ServiceResponse<bool>> RemoveUserProject(UserProjectAddRemoveDTO model);
    }
}