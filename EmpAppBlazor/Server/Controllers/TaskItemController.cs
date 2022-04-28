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
        public async Task<ActionResult<ServiceResponse<List<TaskItemGetDTO>>>> GetTasks()
        {
            return Ok(await _taskItemService.GetTasks());
        }

        [HttpGet("/api/TaskItem/user/{userId}")]
        public async Task<ActionResult<ServiceResponse<List<TaskItemGetDTO>>>> GetTasksByUserId(int userId)
        {
            var result = await _taskItemService.GetTasksByUserId(userId);
            return Ok(result);
        }

        [HttpGet("{taskItemId}")]
        public async Task<ActionResult<ServiceResponse<TaskItemGetDTO>>> GetSingleTaskItem(int taskItemId)
        {
            var result = await _taskItemService.GetSingleTaskItem(taskItemId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<TaskItemGetDTO>>> CreateTaskItem(TaskItemAddDTO taskItem)
        {
            var result = await _taskItemService.CreateTaskItem(taskItem);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<TaskItemGetDTO>>> UpdateTaskItem(TaskItemUpdateDTO taskItem)
        {
            var result = await _taskItemService.UpdateTaskItem(taskItem);
            return Ok(result);
        }

        [HttpPut("/api/TaskItem/status")]
        public async Task<ActionResult<ServiceResponse<TaskItemGetDTO>>> UpdateTaskItemStatusOnly([FromBody] TaskItemToEditStatusDTO taskItem)
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
