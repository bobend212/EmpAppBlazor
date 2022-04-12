namespace EmpAppBlazor.Client.Services.WorkloadService
{
    public class WorkloadService : IWorkloadService
    {
        private readonly HttpClient _http;

        public WorkloadService(HttpClient http)
        {
            _http = http;
        }
        public List<Workload> Workloads { get; set; } = new List<Workload>();

        public async Task GetWorkloads()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Workload>>>("/api/workload");
            if (result != null && result.Data != null)
                Workloads = result.Data;
        }

        public async Task<ServiceResponse<Workload>> GetWorkloadByProjectId(int projectId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Workload>>($"/api/workload/{projectId}");
            return result;
        }

        public async Task<Workload> CreateWorkload(Workload workload)
        {
            var result = await _http.PostAsJsonAsync("api/workload", workload);
            var newWorkload = (await result.Content.ReadFromJsonAsync<ServiceResponse<Workload>>()).Data;
            return newWorkload;
        }

        public async Task<Workload> UpdateWorkload(Workload workload)
        {
            var result = await _http.PutAsJsonAsync("api/workload", workload);
            var newWorkload = (await result.Content.ReadFromJsonAsync<ServiceResponse<Workload>>()).Data;
            return newWorkload;
        }

        public async Task DeleteWorkload(int workloadId)
        {
            var result = await _http.DeleteAsync($"api/workload/{workloadId}");
        }
    }
}
