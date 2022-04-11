namespace EmpAppBlazor.Client.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _http;

        public ProjectService(HttpClient http)
        {
            _http = http;
        }

        public List<Project> Projects { get; set; } = new List<Project>();

        public async Task<ServiceResponse<Project>> GetProject(int projectId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Project>>($"/api/project/{projectId}");
            return result;
        }

        public async Task GetProjects()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Project>>>("/api/project");
            if (result != null && result.Data != null)
                Projects = result.Data;
        }

        public async Task<Project> CreateProject(Project project)
        {
            var result = await _http.PostAsJsonAsync("api/project", project);
            var newProject = (await result.Content.ReadFromJsonAsync<ServiceResponse<Project>>()).Data;
            return newProject;
        }

        public async Task<Project> UpdateProject(Project project)
        {
            var result = await _http.PutAsJsonAsync("api/project", project);
            var newProject = (await result.Content.ReadFromJsonAsync<ServiceResponse<Project>>()).Data;
            return newProject;
        }

        public async Task DeleteProject(int projectId)
        {
            var result = await _http.DeleteAsync($"api/project/{projectId}");
        }
    }
}