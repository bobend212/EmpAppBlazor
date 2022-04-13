namespace EmpAppBlazor.Client.Services.TaskItemService
{
    public interface ITaskItemServiceClient
    {
        List<TaskItem> TaskItems { get; set; }

        Task GetAllTaskItems();

        Task GetAllTaskItemsByUserId(int userId);

        Task<ServiceResponse<TaskItem>> GetSingleTaskItem(int taskItemId);

        Task<TaskItem> CreateTaskItem(TaskItem taskItem);

        Task<TaskItem> UpdateTaskItem(TaskItem taskItem);

        Task<TaskItem> UpdateTaskItemStatus(TaskItem taskItem);

        Task DeleteTaskItem(int taskItemId);
    }
}