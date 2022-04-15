using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Client.Services.UserService
{
    public interface IUserServiceClient
    {
        List<User> Users { get; set; }

        Task GetAllUsers();
    }
}
