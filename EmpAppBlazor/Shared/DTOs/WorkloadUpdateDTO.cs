namespace EmpAppBlazor.Shared.DTOs
{
    public class WorkloadUpdateDTO
    {
        public int Id { get; set; }
        public string ProductionStage { get; set; } = "Not Started";
        public DateTime? DeliveryDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? OrderPlaced { get; set; }
        public string Comments { get; set; } = string.Empty;
        public int ProjectId { get; set; }
        public int? DesignLeaderId { get; set; }
    }
}