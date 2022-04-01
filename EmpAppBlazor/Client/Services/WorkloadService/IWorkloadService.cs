namespace EmpAppBlazor.Client.Services.WorkloadService
{
    public interface IWorkloadService
    {
        List<Workload> Workloads { get; set; }

        Task GetWorkloads();
    }
}
