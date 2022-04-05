namespace EmpAppBlazor.Shared
{
    public class Workload
    {
        public int Id { get; set; }
        public DateTime DueDate { get; set; }
        public string Stage { get; set; } = "unknown";
    }
}