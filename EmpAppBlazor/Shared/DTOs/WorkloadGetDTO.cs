using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Shared.DTOs
{
    public class WorkloadGetDTO
    {
        public int Id { get; set; }
        public virtual ProjectGetDTO? Project { get; set; }
        public int ProjectId { get; set; }
        public UserDTO? DesignLeader { get; set; }
        public int? DesignLeaderId { get; set; }
        public int? AuthorId { get; set; }
        public UserDTO? Author { get; set; }
        public UserDTO? Editor { get; set; }
        public int? EditorId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? OrderPlaced { get; set; }
        public string DesignInfo { get; set; } = string.Empty;
        public bool DrawingsReceived { get; set; }
        public bool EngReceived { get; set; }

        public string SlabStage { get; set; } = "Not Started";
        public string BregsStage { get; set; } = "Not Started";
        public string ProductionStage { get; set; } = "Not Started";

        public bool Issued { get; set; }
        public string Planner { get; set; } = string.Empty;
        public int? EstimDesignTime { get; set; }

        public DateTime? SlabRequired { get; set; }
        public DateTime? SlabEstimated { get; set; }
        public DateTime? SlabIssued { get; set; }

        public DateTime? BregsRequired { get; set; }
        public DateTime? BregsEstimated { get; set; }
        public DateTime? BregsIssued { get; set; }

        public DateTime? FullSetRequired { get; set; }
        public DateTime? FullSetEstimated { get; set; }
        public DateTime? FullSetIssued { get; set; }

        public DateTime? IssuingRequired { get; set; }
        public DateTime? IssuingEstimated { get; set; }
        public DateTime? IssuingIssued { get; set; }

        public DateTime? DeliveryDate { get; set; }
        public string Comments { get; set; } = string.Empty;
    }
}