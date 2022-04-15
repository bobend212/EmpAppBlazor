using AutoMapper;

namespace EmpAppBlazor.Server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<UserDTO>>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            var usersDto = _mapper.Map<List<UserDTO>>(users);
            var response = new ServiceResponse<List<UserDTO>>
            {
                Data = usersDto
            };
            return response;
        }

        public async Task<ServiceResponse<UserDTO>> GetSingleUser(int userId)
        {
            var response = new ServiceResponse<UserDTO>();
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
            var userDto = _mapper.Map<UserDTO>(user);

            if (user == null)
            {
                response.Success = false;
                response.Message = "This user does not exist.";
            }
            else
            {
                response.Data = userDto;
            }

            return response;
        }

        public async Task<ServiceResponse<UserDTO>> UpdateUser(UserUpdateDTO user)
        {
            var findUser = await _context.Users.FindAsync(user.Id);

            if (findUser == null)
            {
                return new ServiceResponse<UserDTO>()
                {
                    Success = false,
                    Message = "User not found."
                };
            }

            var findUserDto = _mapper.Map(user, findUser);

            findUserDto.Email = user.Email;
            findUserDto.Role = user.Role;
            findUserDto.Name = user.Name;
            findUserDto.Surname = user.Surname;
            findUserDto.Department = user.Department; 
            findUserDto.Title = user.Title; 
            findUserDto.UpdateDate = DateTime.Now;

            await _context.SaveChangesAsync();

            var userToReturn = _mapper.Map<UserDTO>(findUserDto);

            return new ServiceResponse<UserDTO> { Data = userToReturn };
        }

        public async Task<ServiceResponse<bool>> DeleteUser(int userId)
        {
            var findUser = await _context.Users.FindAsync(userId);
            if (findUser == null)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Data = false,
                    Message = "User not found."
                };
            }

            _context.Users.Remove(findUser);
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true };
        }
    }
}