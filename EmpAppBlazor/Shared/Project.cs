namespace EmpAppBlazor.Shared
{
    public class Project
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
        public string Status { get; set; } = "unknown";
        public Workload? Workload { get; set; }
        public List<UserProject> UserProjects { get; set; }
    }
}