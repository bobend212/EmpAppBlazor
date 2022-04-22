using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server.Services.WorkloadService
{
    public interface IWorkloadService
    {
        Task<ServiceResponse<List<WorkloadGetDTO>>> GetWorkloads();

        Task<ServiceResponse<WorkloadGetDTO>> GetSingleWorkloadByProjectId(int projectId);

        Task<ServiceResponse<bool>> CreateWorkload(WorkloadAddDTO workload);

        Task<ServiceResponse<bool>> UpdateWorkload(WorkloadUpdateDTO workload);

        Task<ServiceResponse<bool>> DeleteWorkload(int workloadId);
    }
}