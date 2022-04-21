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
        public async Task<ActionResult<ServiceResponse<List<ProjectGetDTO>>>> GetProjects()
        {
            var result = await _projectService.GetProjects();
            return Ok(result);
        }

        [HttpGet("{projectId}")]
        public async Task<ActionResult<ServiceResponse<ProjectGetDTO>>> GetSingleProject(int projectId)
        {
            var result = await _projectService.GetSingleProject(projectId);
            return Ok(result);
        }

        [HttpGet("workload/{workloadStage}")]
        public async Task<ActionResult<ServiceResponse<List<ProjectGetDTO>>>> GetProjectsByWorkloadStage(string workloadStage)
        {
            var result = await _projectService.GetProjectsByWorkloadStage(workloadStage);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<ProjectGetDTO>>> CreateProject(ProjectAddDTO project)
        {
            var result = await _projectService.CreateProject(project);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<ProjectGetDTO>>> UpdateProject(ProjectUpdateDTO project)
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