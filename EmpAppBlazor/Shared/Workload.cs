using EmpAppBlazor.Shared.Auth;
using System.Text.Json.Serialization;

namespace EmpAppBlazor.Shared
{
    public class Workload
    {
        public int Id { get; set; }
        public string ProductionStage { get; set; } = "Not Started";
        public DateTime? DeliveryDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? OrderPlaced { get; set; }
        public string Comments{ get; set; } = string.Empty;
        public DateTime? LastUpdate { get; set; }
        public int? EditorId { get; set; }
        public User? Editor { get; set; }

        [JsonIgnore]
        public virtual Project? Project { get; set; }
        public int ProjectId { get; set; }

        public int? DesignLeaderId { get; set; }
        public User? DesignLeader { get; set; }
    }
}