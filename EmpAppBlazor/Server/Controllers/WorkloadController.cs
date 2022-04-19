using EmpAppBlazor.Shared.DTOs;
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
        public async Task<ActionResult<ServiceResponse<List<Workload>>>> GetWorkloads()
        {
            var result = await _workloadService.GetWorkloads();
            return Ok(result);
        }

        [HttpGet("{projectId}")]
        public async Task<ActionResult<ServiceResponse<Workload>>> GetSingleWorkload(int projectId)
        {
            var result = await _workloadService.GetWorkloadByProjectId(projectId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Workload>>> CreateWorkload(Workload workload)
        {
            var result = await _workloadService.CreateWorkload(workload);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<WorkloadDTO>>> UpdateProject(WorkloadDTO workload)
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