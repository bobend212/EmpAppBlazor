using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server.Services.TaskItemService
{
    public interface ITaskItemService
    {
        Task<ServiceResponse<List<TaskItemGetDTO>>> GetTasks();

        Task<ServiceResponse<List<TaskItemGetDTO>>> GetTasksByUserId(int userId);

        Task<ServiceResponse<TaskItemGetDTO>> GetSingleTaskItem(int taskItemId);

        Task<ServiceResponse<bool>> CreateTaskItem(TaskItemAddDTO taskItem);

        Task<ServiceResponse<bool>> UpdateTaskItem(TaskItemUpdateDTO taskItem);

        Task<ServiceResponse<bool>> UpdateTaskItemStatusOnly(TaskItemToEditStatusDTO taskItemDto);

        Task<ServiceResponse<bool>> DeleteTaskItem(int taskItemId);
    }
}