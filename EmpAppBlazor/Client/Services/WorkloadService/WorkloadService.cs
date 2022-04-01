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
    }
}
