namespace EmpAppBlazor.Shared.Auth
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public string Role { get; set; } = "User";
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime? UpdateDate { get; set; }
        public List<UserProject> UserProjects { get; set; }
    }
}