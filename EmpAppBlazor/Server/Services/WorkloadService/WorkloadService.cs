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

        public async Task<ServiceResponse<Workload>> GetWorkloadByProjectId(int projectId)
        {
            var response = new ServiceResponse<Workload>();
            var workload = await _context.Workloads.Include(w => w.Project).FirstOrDefaultAsync(x => x.ProjectId == projectId);

            if (workload == null)
            {
                response.Success = false;
                response.Message = "This workload does not exist.";
            }
            else
            {
                response.Data = workload;
            }

            return response;
        }

        public async Task<ServiceResponse<Workload>> CreateWorkload(Workload workload)
        {
            _context.Workloads.Add(workload);
            await _context.SaveChangesAsync();

            return new ServiceResponse<Workload> { Data = workload };
        }

        public async Task<ServiceResponse<Workload>> UpdateWorkload(Workload workload)
        {
            var findWorkload = await _context.Workloads.FindAsync(workload.Id);
            if (findWorkload == null)
            {
                return new ServiceResponse<Workload>()
                {
                    Success = false,
                    Message = "Workload not found."
                };
            }

            findWorkload.ProductionStage = workload.ProductionStage;
            findWorkload.DeliveryDate = workload.DeliveryDate;
            findWorkload.RequiredDate = workload.RequiredDate;
            findWorkload.OrderPlaced = workload.OrderPlaced;
            findWorkload.Comments = workload.Comments;

            await _context.SaveChangesAsync();

            return new ServiceResponse<Workload> { Data = workload };
        }

        public async Task<ServiceResponse<bool>> DeleteWorkload(int workloadId)
        {
            var findWorkload = await _context.Workloads.FindAsync(workloadId);
            if (findWorkload == null)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Data = false,
                    Message = "Workload not found."
                };
            }

            _context.Workloads.Remove(findWorkload);
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true };
        }
    }
}