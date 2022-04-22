namespace EmpAppBlazor.Server.Services.WorkloadService
{
    public class WorkloadService : IWorkloadService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public WorkloadService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<WorkloadGetDTO>>> GetWorkloads()
        {
            var workloads = await _context.Workloads.Include(x => x.DesignLeader).Include(x => x.Project).ThenInclude(x => x.UserProjects).ThenInclude(x => x.User).ToListAsync();
            var workloadsDto = _mapper.Map<List<WorkloadGetDTO>>(workloads);
            var response = new ServiceResponse<List<WorkloadGetDTO>>
            {
                Data = workloadsDto
            };
            return response;
        }

        public async Task<ServiceResponse<WorkloadGetDTO>> GetSingleWorkloadByProjectId(int projectId)
        {
            var response = new ServiceResponse<WorkloadGetDTO>();
            var workload = await _context.Workloads.Include(w => w.DesignLeader).Include(x => x.Project).ThenInclude(x => x.UserProjects).ThenInclude(x => x.User).FirstOrDefaultAsync(x => x.ProjectId == projectId);
            var workloadDto = _mapper.Map<WorkloadGetDTO>(workload);

            if (workload == null)
            {
                response.Success = false;
                response.Message = "This workload does not exist.";
            }
            else
            {
                response.Data = workloadDto;
            }
            return response;
        }

        public async Task<ServiceResponse<bool>> CreateWorkload(WorkloadAddDTO workload)
        {
            _context.Workloads.Add(_mapper.Map<Workload>(workload));
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Message = "Workload Created", Data = true };
        }

        public async Task<ServiceResponse<bool>> UpdateWorkload(WorkloadUpdateDTO workload)
        {
            var findWorkload = await _context.Workloads.FindAsync(workload.Id);
            if (findWorkload == null)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Message = "Workload not found.",
                    Data = false
                };
            }

            findWorkload.ProductionStage = workload.ProductionStage;
            findWorkload.DeliveryDate = workload.DeliveryDate;
            findWorkload.RequiredDate = workload.RequiredDate;
            findWorkload.OrderPlaced = workload.OrderPlaced;
            findWorkload.Comments = workload.Comments;
            findWorkload.DesignLeaderId = workload.DesignLeaderId;

            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Message = "Workload Updated", Data = true };
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

            return new ServiceResponse<bool> { Message = "Workload Deleted", Data = true };
        }
    }
}