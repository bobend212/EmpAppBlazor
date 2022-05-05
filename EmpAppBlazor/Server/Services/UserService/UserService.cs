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

        public async Task<ServiceResponse<List<UserDTO>>> GetAllUsersAssignedToProject(int projectId)
        {
            var response = new ServiceResponse<List<UserDTO>>();
            var users =
                from p in _context.Projects
                where p.Id == projectId
                from up in p.UserProjects
                select new UserDTO
                {
                    Id = up.UserId,
                    Name = up.User.Name,
                    Surname = up.User.Surname,
                    ProjectsCount = up.User.UserProjects.Count()
                };

            var usersDto = _mapper.Map<List<UserDTO>>(users);

            response.Data = usersDto;

            return response;
        }

        public async Task<ServiceResponse<List<UserDTO>>> GetAllUsersNotAssignedToProject(int projectId)
        {
            var response = new ServiceResponse<List<UserDTO>>();
            var findProject = await _context.Projects.Include(x => x.UserProjects).ThenInclude(z => z.User).SingleOrDefaultAsync(x => x.Id == projectId);
            var usersAssigned = findProject.UserProjects.Select(x => x.User).ToList();
            var allUsers = await _context.Users.Include(x => x.UserProjects).ToListAsync();
            var usersNotAssigned = allUsers.Where(p => !usersAssigned.Any(p2 => p2.Id == p.Id));

            var users = usersNotAssigned.Select(x => new UserDTO
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                ProjectsCount = x.UserProjects.Count()
            });

            var usersDto = _mapper.Map<List<UserDTO>>(users);

            response.Data = usersDto;

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