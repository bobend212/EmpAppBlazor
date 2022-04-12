namespace EmpAppBlazor.Shared
{
    public class TaskItem
    {
        public int TaskItemId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int AssignedToId { get; set; }
        public int AuthorId { get; set; }
        public int? EditorId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? DueDate { get; set; }
        public string TaskStatus { get; set; } = string.Empty;
        public string Importance { get; set; } = string.Empty;
        public DateTime? DateCreated { get; set; }
        public DateTime? DateEdited { get; set; }
    }
}