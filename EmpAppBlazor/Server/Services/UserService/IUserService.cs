namespace EmpAppBlazor.Server.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<List<UserDTO>>> GetAllUsers();

        Task<ServiceResponse<List<UserDTO>>> GetAllUsersAssignedToProject(int projectId);

        Task<ServiceResponse<List<UserDTO>>> GetAllUsersNotAssignedToProject(int projectId);

        Task<ServiceResponse<UserDTO>> GetSingleUser(int userId);

        Task<ServiceResponse<UserDTO>> UpdateUser(UserUpdateDTO user);

        Task<ServiceResponse<bool>> DeleteUser(int userId);
    }
}