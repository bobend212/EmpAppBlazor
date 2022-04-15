using EmpAppBlazor.Server.Services.TaskItemService;
using EmpAppBlazor.Shared.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpAppBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemController : ControllerBase
    {
        private readonly ITaskItemService _taskItemService;

        public TaskItemController(ITaskItemService taskItemService)
        {
            _taskItemService = taskItemService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<TaskItem>>>> GetAllTasks()
        {
            return Ok(await _taskItemService.GetAllTasks());
        }

        [HttpGet("/api/TaskItem/user/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<TaskItem>>>> GetAllTasksByUserId(int userId)
        {
            var result = await _taskItemService.GetAllTasksByUserId(userId);
            return Ok(result);
        }

        [HttpGet("{taskItemId}")]
        public async Task<ActionResult<ServiceResponse<TaskItem>>> GetSingleTaskItem(int taskItemId)
        {
            var result = await _taskItemService.GetTaskItem(taskItemId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<TaskItem>>> CreateTaskItem(TaskItem taskItem)
        {
            var result = await _taskItemService.PostTaskItem(taskItem);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<TaskItem>>> UpdateTaskItem(TaskItem taskItem)
        {
            var result = await _taskItemService.UpdateTaskItem(taskItem);
            return Ok(result);
        }

        [HttpPut("/api/status")]
        public async Task<ActionResult<ServiceResponse<TaskItem>>> UpdateTaskItemStatusOnly([FromBody] TaskItemToEditStatusDTO taskItem)
        {
            var result = await _taskItemService.UpdateTaskItemStatusOnly(taskItem);
            return Ok(result);
        }

        [HttpDelete("{taskItemId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteTaskItem(int taskItemId)
        {
            var result = await _taskItemService.DeleteTaskItem(taskItemId);
            return Ok(result);
        }
    }
}
