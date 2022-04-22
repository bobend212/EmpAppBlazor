namespace EmpAppBlazor.Client.Services.WorkloadService
{
    public class WorkloadServiceClient : IWorkloadServiceClient
    {
        private readonly HttpClient _http;
        private readonly ISnackbar _snackBar;

        public WorkloadServiceClient(HttpClient http, ISnackbar snackBar)
        {
            _http = http;
            _snackBar = snackBar;
        }

        public List<WorkloadGetDTO> Workloads { get; set; } = new List<WorkloadGetDTO>();

        public async Task GetWorkloads()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<WorkloadGetDTO>>>("/api/workload");
            if (result != null && result.Data != null)
                Workloads = result.Data;
        }

        public async Task<ServiceResponse<WorkloadGetDTO>> GetSingleWorkloadByProjectId(int projectId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<WorkloadGetDTO>>($"/api/workload/{projectId}");
            return result;
        }

        public async Task CreateWorkload(WorkloadGetDTO workload)
        {
            var result = await _http.PostAsJsonAsync("api/workload", workload);
            DisplaySnackBarMessage(result, "Workload", "Create");
        }

        public async Task UpdateWorkload(WorkloadGetDTO workload)
        {
            var result = await _http.PutAsJsonAsync("api/workload", workload);
            DisplaySnackBarMessage(result, "Workload", "Update");
        }

        public async Task DeleteWorkload(int workloadId)
        {
            var result = await _http.DeleteAsync($"api/workload/{workloadId}");
            DisplaySnackBarMessage(result, "Workload", "Delete");
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