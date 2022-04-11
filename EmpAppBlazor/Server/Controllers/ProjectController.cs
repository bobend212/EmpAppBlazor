using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("{projectId}")]
        public async Task<ActionResult<ServiceResponse<Project>>> GetSingleProject(int projectId)
        {
            var result = await _projectService.GetProjectAsync(projectId);
            return Ok(result);
        }

        [HttpGet("workload/{workloadStage}")]
        public async Task<ActionResult<ServiceResponse<Project>>> GetProjectsByWorkloadStage(string workloadStage)
        {
            var result = await _projectService.GetProjectsByWorkloadStage(workloadStage);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Project>>> CreateProject(Project project)
        {
            var result = await _projectService.CreateProject(project);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Project>>> UpdateProject(Project project)
        {
            var result = await _projectService.UpdateProject(project);
            return Ok(result);
        }

        [HttpDelete("{projectId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProject(int projectId)
        {
            var result = await _projectService.DeleteProject(projectId);
            return Ok(result);
        }
    }
}