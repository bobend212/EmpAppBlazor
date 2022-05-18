namespace EmpAppBlazor.Server.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(User user, string password);

        Task<bool> UserExist(string email);

        Task<ServiceResponse<string>> Login(string email, string password);

        Task<ServiceResponse<bool>> ChangePassword(int userId, string newPassword);

        Task<ServiceResponse<bool>> ChangeAccountDetails(int userId, UserAccountDetails model);
    }
}