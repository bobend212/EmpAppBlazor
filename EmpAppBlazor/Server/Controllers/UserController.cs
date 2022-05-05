using Microsoft.AspNetCore.Mvc;

namespace EmpAppBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<UserDTO>>>> GetAllUsers()
        {
            return await _userService.GetAllUsers();
        }

        [HttpGet("{projectId}/users-assigned")]
        public async Task<ActionResult<ServiceResponse<List<UserDTO>>>> GetAllUsersAssignedToProject(int projectId)
        {
            return await _userService.GetAllUsersAssignedToProject(projectId);
        }

        [HttpGet("{projectId}/users-not-assigned")]
        public async Task<ActionResult<ServiceResponse<List<UserDTO>>>> GetAllUsersNotAssignedToProject(int projectId)
        {
            return await _userService.GetAllUsersNotAssignedToProject(projectId);
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<ServiceResponse<UserDTO>>> GetSingleUser(int userId)
        {
            return await _userService.GetSingleUser(userId);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<UserDTO>>> UpdateUser(UserUpdateDTO user)
        {
            var result = await _userService.UpdateUser(user);
            return Ok(result);
        }

        [HttpDelete("{userId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProject(int userId)
        {
            var result = await _userService.DeleteUser(userId);
            return Ok(result);
        }
    }
}