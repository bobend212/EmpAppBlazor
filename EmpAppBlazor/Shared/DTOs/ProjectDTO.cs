using EmpAppBlazor.Shared.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAppBlazor.Shared.DTOs
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
        public string Status { get; set; } = "unknown";

        public List<UserDTO> Designers { get; set; }

        public WorkloadDTO Workload { get; set; }
    }
}
