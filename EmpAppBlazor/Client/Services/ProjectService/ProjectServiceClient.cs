namespace EmpAppBlazor.Client.Services.ProjectService
{
    public class ProjectServiceClient : IProjectServiceClient
    {
        private readonly HttpClient _http;
        private readonly ISnackbar _snackBar;

        public ProjectServiceClient(HttpClient http, ISnackbar snackBar)
        {
            _http = http;
            _snackBar = snackBar;
        }

        public List<ProjectGetDTO> Projects { get; set; } = new List<ProjectGetDTO>();

        public async Task GetProjects()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<ProjectGetDTO>>>("/api/project");
            if (result != null && result.Data != null)
                Projects = result.Data;
        }

        public async Task<ServiceResponse<ProjectGetDTO>> GetSingleProject(int projectId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<ProjectGetDTO>>($"/api/project/{projectId}");
            return result;
        }

        public async Task CreateProject(ProjectGetDTO project)
        {
            var result = await _http.PostAsJsonAsync("api/project", project);
            DisplaySnackBarMessage(result, "Project", "Create");
        }

        public async Task UpdateProject(ProjectGetDTO project)
        {
            var result = await _http.PutAsJsonAsync("api/project", project);
            DisplaySnackBarMessage(result, "Project", "Update");
        }

        public async Task DeleteProject(int projectId)
        {
            var result = await _http.DeleteAsync($"api/project/{projectId}");
            DisplaySnackBarMessage(result, "Project", "Delete");
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