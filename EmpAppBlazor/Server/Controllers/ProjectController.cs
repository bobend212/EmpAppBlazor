using EmpAppBlazor.Server.Data;
using EmpAppBlazor.Server.Services.ProjectService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmpAppBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Project>>>> GetProjects()
        {
            var result = await _projectService.GetProjectsAsync();
            return Ok(result);
        }
    }
}
