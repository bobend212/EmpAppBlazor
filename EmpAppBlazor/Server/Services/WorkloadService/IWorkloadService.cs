using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server.Services.WorkloadService
{
    public interface IWorkloadService
    {
        Task<ServiceResponse<List<WorkloadDTO>>> GetWorkloads();

        Task<ServiceResponse<Workload>> GetWorkloadByProjectId(int projectId);

        Task<ServiceResponse<Workload>> CreateWorkload(Workload workload);

        Task<ServiceResponse<WorkloadDTO>> UpdateWorkload(WorkloadDTO workload);

        Task<ServiceResponse<bool>> DeleteWorkload(int workloadId);
    }
}