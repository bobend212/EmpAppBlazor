using EmpAppBlazor.Shared.Auth;
using MudBlazor;

namespace EmpAppBlazor.Client.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        private readonly ISnackbar _snackBar;

        public AuthService(HttpClient http, ISnackbar snackBar)
        {
            _http = http;
            _snackBar = snackBar;
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", request);
            if(result.IsSuccessStatusCode)
            {
                _snackBar.Add("New User Registered", Severity.Success); 
            }
            else
            {
                _snackBar.Add("Registration failure", Severity.Error);
            }
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
        }
    }
}
