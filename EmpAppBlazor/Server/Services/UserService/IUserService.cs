namespace EmpAppBlazor.Server.Services.UserService
{
    public interface IUserService
    {
        Task<ServiceResponse<List<UserDTO>>> GetAllUsers();

        Task<ServiceResponse<UserDTO>> GetSingleUser(int userId);

        Task<ServiceResponse<UserDTO>> UpdateUser(UserUpdateDTO user);

        Task<ServiceResponse<bool>> DeleteUser(int userId);
    }
}