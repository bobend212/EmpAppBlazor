namespace EmpAppBlazor.Client.Services.ProjectService
{
    public class ProjectServiceClient : IProjectServiceClient
    {
        private readonly HttpClient _http;

        public ProjectServiceClient(HttpClient http)
        {
            _http = http;
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
        }

        public async Task UpdateProject(ProjectGetDTO project)
        {
            var result = await _http.PutAsJsonAsync("api/project", project);
        }

        public async Task DeleteProject(int projectId)
        {
            var result = await _http.DeleteAsync($"api/project/{projectId}");
        }
    }
}