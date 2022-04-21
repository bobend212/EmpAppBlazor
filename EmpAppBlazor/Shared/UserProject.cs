using EmpAppBlazor.Shared.Auth;

namespace EmpAppBlazor.Shared
{
    public class UserProject
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}