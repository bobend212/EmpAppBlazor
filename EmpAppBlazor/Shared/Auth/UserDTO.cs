namespace EmpAppBlazor.Shared.Auth
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime? DateCreated { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime? UpdateDate { get; set; }
        public int ProjectsCount { get; set; }
    }
}