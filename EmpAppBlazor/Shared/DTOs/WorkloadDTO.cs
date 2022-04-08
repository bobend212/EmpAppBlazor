namespace EmpAppBlazor.Shared.DTOs
{
    public class WorkloadDTO
    {
        public int Id { get; set; }
        public string ProductionStage { get; set; } = "not started";
        public DateTime? DeliveryDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? OrderPlaced { get; set; }
        public string Comments { get; set; } = string.Empty;
    }
}