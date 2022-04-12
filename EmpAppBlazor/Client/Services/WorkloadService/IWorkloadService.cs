namespace EmpAppBlazor.Client.Services.WorkloadService
{
    public interface IWorkloadService
    {
        List<Workload> Workloads { get; set; }

        Task GetWorkloads();

        Task<ServiceResponse<Workload>> GetWorkloadByProjectId(int projectId);

        Task<Workload> CreateWorkload(Workload workload);

        Task<Workload> UpdateWorkload(Workload workload);

        Task DeleteWorkload(int workloadId);
    }
}