namespace EmpAppBlazor.Shared.DTOs
{
    public class ProjectAddDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
        public string Status { get; set; } = "Not Started";
    }
}