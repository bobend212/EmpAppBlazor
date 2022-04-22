using Microsoft.AspNetCore.Mvc;

namespace EmpAppBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkloadController : ControllerBase
    {
        private readonly IWorkloadService _workloadService;

        public WorkloadController(IWorkloadService workloadService)
        {
            _workloadService = workloadService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<WorkloadGetDTO>>>> GetWorkloads()
        {
            var result = await _workloadService.GetWorkloads();
            return Ok(result);
        }

        [HttpGet("{projectId}")]
        public async Task<ActionResult<ServiceResponse<WorkloadGetDTO>>> GetSingleWorkloadByProjectId(int projectId)
        {
            var result = await _workloadService.GetSingleWorkloadByProjectId(projectId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<WorkloadGetDTO>>> CreateWorkload(WorkloadAddDTO workload)
        {
            var result = await _workloadService.CreateWorkload(workload);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<WorkloadGetDTO>>> UpdateProject(WorkloadUpdateDTO workload)
        {
            var result = await _workloadService.UpdateWorkload(workload);
            return Ok(result);
        }

        [HttpDelete("{workloadId}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteProject(int workloadId)
        {
            var result = await _workloadService.DeleteWorkload(workloadId);
            return Ok(result);
        }
    }
}