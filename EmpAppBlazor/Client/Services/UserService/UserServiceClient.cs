using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Client.Services.UserService
{
    public class UserServiceClient : IUserServiceClient
    {
        private readonly HttpClient _http;
        private readonly ISnackbar _snackBar;

        public List<User> Users { get; set; } = new List<User>();
        public List<User> UsersAssigned { get; set; } = new List<User>();
        public List<User> UsersNotAssigned { get; set; } = new List<User>();

        public UserServiceClient(HttpClient http, ISnackbar snackBar)
        {
            _http = http;
            _snackBar = snackBar;
        }

        public async Task GetAllUsers()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<User>>>("/api/User");
            if (result != null && result.Data != null)
                Users = result.Data;
        }

        public async Task GetAllUsersAssignedToProject(int projectId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<User>>>($"/api/User/{projectId}/users-assigned");
            if (result != null && result.Data != null)
                UsersAssigned = result.Data;
        }

        public async Task GetAllUsersNotAssignedToProject(int projectId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<User>>>($"/api/User/{projectId}/users-not-assigned");
            if (result != null && result.Data != null)
                UsersNotAssigned = result.Data;
        }

        public async Task AssignUserToProject(UserProjectAddRemoveDTO model)
        {
            var result = await _http.PostAsJsonAsync("api/userproject", model);
            var x = result.Content.ReadFromJsonAsync<ServiceResponse<bool>>().Result;
            if (x.Success == true)
            {
                DisplaySnackBarMessage(result, "User-Project", x.Message);
            }
            else
            {
                DisplaySnackBarMessage(result, "User-Project", x.Message);
            }
        }

        public async Task RemoveUserFromProject(UserProjectAddRemoveDTO model)
        {
            //to do
        }

        private void DisplaySnackBarMessage(HttpResponseMessage result, string entity, string operation)
        {
            if (result.IsSuccessStatusCode)
                _snackBar.Add($"{entity} {operation} | Success", Severity.Success);
            else
                _snackBar.Add($"Something went wrong | [{entity} {operation}]", Severity.Error);
        }
    }
}