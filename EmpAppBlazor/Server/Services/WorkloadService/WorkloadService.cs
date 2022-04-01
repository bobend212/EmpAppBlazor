namespace EmpAppBlazor.Server.Services.WorkloadService
{
    public class WorkloadService : IWorkloadService
    {
        private readonly DataContext _context;

        public WorkloadService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Workload>>> GetWorkloads()
        {
            var workloads = await _context.Workloads.ToListAsync();
            return new ServiceResponse<List<Workload>>
            {
                Data = workloads
            };
        }
    }
}
