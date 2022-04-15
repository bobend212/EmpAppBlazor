using EmpAppBlazor.Shared.Auth;
using MudBlazor;

namespace EmpAppBlazor.Client.Services.UserService
{
    public class UserServiceClient : IUserServiceClient
    {
        private readonly HttpClient _http;
        private readonly ISnackbar _snackBar;

        public UserServiceClient(HttpClient http, ISnackbar snackBar)
        {
            _http = http;
            _snackBar = snackBar;
        }

        public List<User> Users { get; set; } = new List<User>();

        public async Task GetAllUsers()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<User>>>("/api/User");
            if (result != null && result.Data != null)
                Users = result.Data;
        }
    }
}
