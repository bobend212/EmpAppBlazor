using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Client.Services.AuthService
{
    public class AuthServiceClient : IAuthServiceClient
    {
        private readonly HttpClient _http;
        private readonly ISnackbar _snackBar;

        public AuthServiceClient(HttpClient http, ISnackbar snackBar)
        {
            _http = http;
            _snackBar = snackBar;
        }

        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/login", request);
            if (result.IsSuccessStatusCode)
            {
                _snackBar.Add("Welcome", Severity.Success);
            }
            else
            {
                _snackBar.Add("Login failure", Severity.Error);
            }
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/register", request);
            var x = result.Content.ReadFromJsonAsync<ServiceResponse<int>>().Result;

            if (x.Success == true)
            {
                _snackBar.Add("New User Registered", Severity.Success);
            }
            else
            {
                _snackBar.Add($"Registration failure: {x.Message}", Severity.Error);
            }
            return x;
        }

        public async Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/change-password", request.Password);
            if (result.IsSuccessStatusCode)
            {
                _snackBar.Add("Password has been changed.", Severity.Success);
            }
            else
            {
                _snackBar.Add("Password change failure", Severity.Error);
            }
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }

        public async Task<ServiceResponse<bool>> ChangeAccountDetails(UserDTO request)
        {
            var result = await _http.PostAsJsonAsync("api/auth/change-account-details", request);
            if (result.IsSuccessStatusCode)
            {
                _snackBar.Add("Account Details has been changed.", Severity.Success);
            }
            else
            {
                _snackBar.Add("Account Details change failure", Severity.Error);
            }
            return await result.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
        }
    }
}