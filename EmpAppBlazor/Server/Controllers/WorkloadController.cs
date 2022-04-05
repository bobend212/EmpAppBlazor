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
    }
}