using System.Text.Json.Serialization;

namespace EmpAppBlazor.Shared
{
    public class Workload
    {
        public int Id { get; set; }
        public string ProductionStage { get; set; } = "not started";
        public DateTime? DeliveryDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? OrderPlaced { get; set; }
        public string Comments{ get; set; } = string.Empty;

        [JsonIgnore]
        public virtual Project? Project { get; set; }
        public int ProjectId { get; set; }
    }
}