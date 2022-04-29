namespace EmpAppBlazor.Server.Services.UserProjectService
{
    public class UserProjectService : IUserProjectService
    {
        private readonly DataContext _context;

        public UserProjectService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<bool>> AddUserProject(UserProjectAddRemoveDTO model)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
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

                var checkIfRelationExist = _context.UserProjects.Where(x => x.User == user && x.Project == project).Count();
                if (checkIfRelationExist > 0)
                {
                    response.Success = false;
                    response.Message = "This relation already exist.";
                    return response;
                }

                await _context.UserProjects.AddAsync(userProject);
                await _context.SaveChangesAsync();
                response.Data = true;
                response.Message = "Relation User-Project CREATED successfully.";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<bool>> RemoveUserProject(UserProjectAddRemoveDTO model)
        {
            ServiceResponse<bool> response = new ServiceResponse<bool>();
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

                var checkIfRelationExist = _context.UserProjects.Where(x => x.User == user && x.Project == project).Count();
                if (checkIfRelationExist < 1)
                {
                    response.Success = false;
                    response.Message = "This relation not exist.";
                    return response;
                }

                _context.UserProjects.Remove(userProject);
                await _context.SaveChangesAsync();
                response.Data = true;
                response.Message = "Relation User-Project REMOVED successfully.";
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