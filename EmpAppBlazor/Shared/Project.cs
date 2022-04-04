using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmpAppBlazor.Shared
{
    public class Project
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
        public DateTime DeliveryDate { get; set; }

        [JsonIgnore]
        public Workload? Workload { get; set; }
        public int WorkloadId { get; set; }
    }
}
