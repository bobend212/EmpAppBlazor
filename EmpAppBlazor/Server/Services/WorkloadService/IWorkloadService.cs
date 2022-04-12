namespace EmpAppBlazor.Server.Services.WorkloadService
{
    public interface IWorkloadService
    {
        Task<ServiceResponse<List<Workload>>> GetWorkloads();

        Task<ServiceResponse<Workload>> GetWorkloadByProjectId(int projectId);

        Task<ServiceResponse<Workload>> CreateWorkload(Workload workload);

        Task<ServiceResponse<Workload>> UpdateWorkload(Workload workload);

        Task<ServiceResponse<bool>> DeleteWorkload(int workloadId);
    }
}