using AutoMapper;
using EmpAppBlazor.Shared.DTOs;

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

        public async Task<ServiceResponse<List<WorkloadDTO>>> GetWorkloads()
        {
            var workloads = await _context.Workloads.Include(x => x.DesignLeader).ToListAsync();
            var workloadsDto = _mapper.Map<List<WorkloadDTO>>(workloads);
            return new ServiceResponse<List<WorkloadDTO>>
            {
                Data = workloadsDto
            };
        }

        public async Task<ServiceResponse<Workload>> GetWorkloadByProjectId(int projectId)
        {
            var response = new ServiceResponse<Workload>();
            var workload = await _context.Workloads.Include(w => w.Project).Include(x => x.DesignLeader).FirstOrDefaultAsync(x => x.ProjectId == projectId);

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

        public async Task<ServiceResponse<WorkloadDTO>> UpdateWorkload(WorkloadDTO workload)
        {
            var findWorkload = await _context.Workloads.FindAsync(workload.Id);
            if (findWorkload == null)
            {
                return new ServiceResponse<WorkloadDTO>()
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
            findWorkload.DesignLeaderId = workload.DesignLeaderId;

            await _context.SaveChangesAsync();

            return new ServiceResponse<WorkloadDTO> { Data = workload };
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