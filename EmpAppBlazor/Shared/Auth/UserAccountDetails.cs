namespace EmpAppBlazor.Shared.Auth
{
    public class UserAccountDetails
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public DateTime? UpdateDate { get; set; }
    }
}