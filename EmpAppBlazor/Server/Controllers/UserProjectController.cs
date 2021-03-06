using Microsoft.AspNetCore.Mvc;

namespace EmpAppBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProjectController : ControllerBase
    {
        private readonly IUserProjectService _userProjectService;

        public UserProjectController(IUserProjectService userProjectService)
        {
            _userProjectService = userProjectService;
        }

        [HttpPost]
        public async Task<IActionResult> AddUserProject(UserProjectAddRemoveDTO model)
        {
            return Ok(await _userProjectService.AddUserProject(model));
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveUserProject(UserProjectAddRemoveDTO model)
        {
            return Ok(await _userProjectService.RemoveUserProject(model));
        }
    }
}