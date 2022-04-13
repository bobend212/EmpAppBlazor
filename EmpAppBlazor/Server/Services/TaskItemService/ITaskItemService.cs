namespace EmpAppBlazor.Server.Services.TaskItemService
{
    public interface ITaskItemService
    {
        Task<ServiceResponse<List<TaskItem>>> GetAllTasks();

        Task<ServiceResponse<List<TaskItem>>> GetAllTasksByUserId(int userId);

        Task<ServiceResponse<TaskItem>> GetTaskItem(int taskItemId);

        Task<ServiceResponse<TaskItem>> PostTaskItem(TaskItem taskItem);

        Task<ServiceResponse<TaskItem>> UpdateTaskItem(TaskItem taskItem);

        Task<ServiceResponse<bool>> DeleteTaskItem(int taskItemId);
    }
}