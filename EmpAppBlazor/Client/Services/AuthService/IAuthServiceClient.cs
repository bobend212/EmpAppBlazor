using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Client.Services.AuthService
{
    public interface IAuthServiceClient
    {
        Task<ServiceResponse<int>> Register(UserRegister request);

        Task<ServiceResponse<string>> Login(UserLogin request);

        Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request);

        Task<ServiceResponse<bool>> ChangeAccountDetails(UserDTO request);
    }
}