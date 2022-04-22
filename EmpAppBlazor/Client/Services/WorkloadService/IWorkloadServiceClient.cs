namespace EmpAppBlazor.Client.Services.WorkloadService
{
    public interface IWorkloadServiceClient
    {
        List<WorkloadGetDTO> Workloads { get; set; }

        Task GetWorkloads();

        Task<ServiceResponse<WorkloadGetDTO>> GetSingleWorkloadByProjectId(int projectId);

        Task CreateWorkload(WorkloadGetDTO workload);

        Task UpdateWorkload(WorkloadGetDTO workload);

        Task DeleteWorkload(int workloadId);
    }
}