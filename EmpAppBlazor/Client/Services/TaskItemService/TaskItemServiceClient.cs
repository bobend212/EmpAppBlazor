namespace EmpAppBlazor.Client.Services.TaskItemService
{
    public class TaskItemServiceClient : ITaskItemServiceClient
    {
        private readonly HttpClient _http;
        private readonly ISnackbar _snackBar;

        public TaskItemServiceClient(HttpClient http, ISnackbar snackBar)
        {
            _http = http;
            _snackBar = snackBar;
        }

        public List<TaskItemGetDTO> TaskItems { get; set; } = new List<TaskItemGetDTO>();

        public async Task GetTasks()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<TaskItemGetDTO>>>("/api/TaskItem");
            if (result != null && result.Data != null)
                TaskItems = result.Data;
        }

        public async Task GetTasksByUserId(int userId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<TaskItemGetDTO>>>($"/api/TaskItem/user/{userId}");
            if (result != null && result.Data != null)
                TaskItems = result.Data;
        }

        public async Task<ServiceResponse<TaskItemGetDTO>> GetSingleTaskItem(int taskItemId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<TaskItemGetDTO>>($"/api/TaskItem/{taskItemId}");
            return result;
        }

        public async Task CreateTaskItem(TaskItemGetDTO taskItem)
        {
            var result = await _http.PostAsJsonAsync("api/TaskItem", taskItem);
            DisplaySnackBarMessage(result, "TaskItem", "Create");
        }

        public async Task UpdateTaskItem(TaskItemGetDTO taskItem)
        {
            var result = await _http.PutAsJsonAsync("api/TaskItem", taskItem);
            DisplaySnackBarMessage(result, "TaskItem", "Update");
        }

        public async Task UpdateTaskItemStatus(TaskItemGetDTO taskItem)
        {
            var result = await _http.PutAsJsonAsync("api/TaskItem/status", taskItem);
            DisplaySnackBarMessage(result, "TaskItem", "Update Status");
        }

        public async Task DeleteTaskItem(int taskItemId)
        {
            var result = await _http.DeleteAsync($"api/TaskItem/{taskItemId}");
            DisplaySnackBarMessage(result, "TaskItem", "Delete");
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