using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Client.Services.AuthService
{
    public interface IAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegister request);
    }
}
