using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Client.Services.UserService
{
    public interface IUserServiceClient
    {
        List<User> Users { get; set; }
        List<User> UsersAssigned { get; set; }
        List<User> UsersNotAssigned { get; set; }

        Task GetAllUsers();

        Task GetAllUsersAssignedToProject(int projectId);

        Task GetAllUsersNotAssignedToProject(int projectId);

        Task AssignUserToProject(UserProjectAddRemoveDTO model);

        Task RemoveUserFromProject(UserProjectAddRemoveDTO model);
    }
}