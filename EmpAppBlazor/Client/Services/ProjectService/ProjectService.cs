using EmpAppBlazor.Shared;
using System.Net.Http.Json;

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

        public async Task GetProjects()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Project>>>("/api/project");
            if (result != null && result.Data != null)
                Projects = result.Data;
        }
    }
}
