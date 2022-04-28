namespace EmpAppBlazor.Client.Services.TaskItemService
{
    public interface ITaskItemServiceClient
    {
        List<TaskItemGetDTO> TaskItems { get; set; }

        Task GetTasks();

        Task GetTasksByUserId(int userId);

        Task<ServiceResponse<TaskItemGetDTO>> GetSingleTaskItem(int taskItemId);

        Task CreateTaskItem(TaskItemGetDTO taskItem);

        Task UpdateTaskItem(TaskItemGetDTO taskItem);

        Task UpdateTaskItemStatus(TaskItemGetDTO taskItem);

        Task DeleteTaskItem(int taskItemId);
    }
}