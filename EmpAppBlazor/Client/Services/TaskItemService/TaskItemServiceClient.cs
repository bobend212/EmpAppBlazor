using MudBlazor;

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

        public List<TaskItem> TaskItems { get; set; } = new List<TaskItem>();

        public async Task GetAllTaskItems()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<TaskItem>>>("/api/TaskItem");
            if (result != null && result.Data != null)
                TaskItems = result.Data;
        }

        public async Task GetAllTaskItemsByUserId(int userId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<TaskItem>>>($"/api/TaskItem/user/{userId}");
            if (result != null && result.Data != null)
                TaskItems = result.Data;
        }

        public Task<ServiceResponse<TaskItem>> GetSingleTaskItem(int taskItemId)
        {
            throw new NotImplementedException();
        }

        public async Task<TaskItem> CreateTaskItem(TaskItem taskItem)
        {
            var result = await _http.PostAsJsonAsync("/api/taskItem", taskItem);
            var newTask = (await result.Content.ReadFromJsonAsync<ServiceResponse<TaskItem>>()).Data;
            return newTask;
        }

        public Task<TaskItem> UpdateTaskItem(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }

        public async Task<TaskItem> UpdateTaskItemStatus(TaskItem taskItem)
        {
            var result = await _http.PutAsJsonAsync("api/status", taskItem);
            var newTaskItemStatus = (await result.Content.ReadFromJsonAsync<ServiceResponse<TaskItem>>()).Data;
            _snackBar.Add("Task status updated", Severity.Success);
            return newTaskItemStatus;
        }

        public Task DeleteTaskItem(int taskItemId)
        {
            throw new NotImplementedException();
        }
    }
}