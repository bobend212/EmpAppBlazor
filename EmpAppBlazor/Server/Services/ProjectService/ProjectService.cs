namespace EmpAppBlazor.Server.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly DataContext _context;

        public ProjectService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<Project>> GetProjectAsync(int projectId)
        {
            var response = new ServiceResponse<Project>();
            var project = await _context.Projects.Include(w => w.Workload).FirstOrDefaultAsync(x => x.Id == projectId);

            if (project == null)
            {
                response.Success = false;
                response.Message = "This project does not exist.";
            }
            else
            {
                response.Data = project;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Project>>> GetProjectsAsync()
        {

            var response = new ServiceResponse<List<Project>>()
            {
                Data = await _context.Projects.Include(w => w.Workload).Include(x => x.Designers.Select(x => new UserDTO
                {
                    Id = x.Id,
                    Email = x.Email
                }).ToArray()).ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Project>>> GetProjectsByWorkloadStage(string stageWorkload)
        {
            var response = new ServiceResponse<List<Project>>()
            {
                Data = await _context.Projects.Where(x => x.Workload.ProductionStage.ToLower().Equals(stageWorkload.ToLower())).ToListAsync()
            };
            return response;
        }
    }
}