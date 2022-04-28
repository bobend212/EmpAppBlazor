using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Shared.DTOs
{
    public class TaskItemGetDTO
    {
        public int TaskItemId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? AssignedToId { get; set; }
        public UserDTO? AssignedTo { get; set; }
        public int AuthorId { get; set; }
        public UserDTO? Author { get; set; }
        public int? EditorId { get; set; }
        public UserDTO? Editor { get; set; }
        public int? ProjectId { get; set; }
        public ProjectGetDTO? Project { get; set; }
        public DateTime? DueDate { get; set; }
        public string TaskStatus { get; set; } = string.Empty;
        public string Importance { get; set; } = string.Empty;
        public DateTime? DateCreated { get; set; }
        public DateTime? DateEdited { get; set; }
    }
}