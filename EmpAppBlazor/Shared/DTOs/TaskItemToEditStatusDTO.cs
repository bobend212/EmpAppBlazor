namespace EmpAppBlazor.Shared.DTOs
{
    public class TaskItemToEditStatusDTO
    {
        public int TaskItemId { get; set; }
        public string TaskStatus { get; set; }
        public int? EditorId { get; set; }
    }
}