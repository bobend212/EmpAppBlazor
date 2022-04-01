namespace EmpAppBlazor.Server.Services.WorkloadService
{
    public interface IWorkloadService
    {
        Task<ServiceResponse<List<Workload>>> GetWorkloads();
    }
}
