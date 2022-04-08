using EmpAppBlazor.Shared.Auth;
using System.Text.Json.Serialization;

namespace EmpAppBlazor.Shared
{
    public class Project
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
        public string Status { get; set; } = "unknown";

        public List<User> Designers { get; set; }

        public Workload Workload { get; set; }
    }
}