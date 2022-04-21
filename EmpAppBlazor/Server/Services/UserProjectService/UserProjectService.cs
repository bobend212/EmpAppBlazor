using AutoMapper;

namespace EmpAppBlazor.Server.Services.UserProjectService
{
    public class UserProjectService : IUserProjectService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserProjectService(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<ProjectGetDTO>> AddUserProject(UserProjectAddDTO model)
        {
            ServiceResponse<ProjectGetDTO> response = new ServiceResponse<ProjectGetDTO>();
            try
            {
                User user = await _context.Users.FindAsync(model.UserId);
                if (user == null)
                {
                    response.Success = false;
                    response.Message = "User not found.";
                    return response;
                }

                Project project = await _context.Projects.FindAsync(model.ProjectId);
                if (project == null)
                {
                    response.Success = false;
                    response.Message = "Project not found.";
                    return response;
                }

                UserProject userProject = new UserProject
                {
                    User = user,
                    Project = project
                };

                await _context.UserProjects.AddAsync(userProject);
                await _context.SaveChangesAsync();
                response.Data = _mapper.Map<ProjectGetDTO>(project);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}