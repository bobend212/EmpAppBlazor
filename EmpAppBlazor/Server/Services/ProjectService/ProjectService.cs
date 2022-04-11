using AutoMapper;
using EmpAppBlazor.Shared.DTOs;

namespace EmpAppBlazor.Server.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ProjectService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<Project>> GetProjectAsync(int projectId)
        {
            var response = new ServiceResponse<Project>();
            var project = await _context.Projects.Include(w => w.Workload).Include(x => x.Designers).FirstOrDefaultAsync(x => x.Id == projectId);

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

        public async Task<ServiceResponse<List<ProjectDTO>>> GetProjectsAsync()
        {
            var projects = await _context.Projects.Include(w => w.Workload).Include(x => x.Designers).ToListAsync();
            var projectsDto = _mapper.Map<List<ProjectDTO>>(projects);

            var response = new ServiceResponse<List<ProjectDTO>>()
            {
                Data = projectsDto
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

        public async Task<ServiceResponse<Project>> CreateProject(Project project)
        {
            project.Designers = null;
            project.Workload = null;

            _context.Projects.Add(project);
            await _context.SaveChangesAsync();

            return new ServiceResponse<Project> { Data = project };
        }

        public async Task<ServiceResponse<Project>> UpdateProject(Project project)
        {
            var findProject = await _context.Projects.FindAsync(project.Id);
            if (findProject == null)
            {
                return new ServiceResponse<Project>()
                {
                    Success = false,
                    Message = "Project not found."
                };
            }

            findProject.Number = project.Number;
            findProject.Name = project.Name;
            findProject.Site = project.Site;
            findProject.Status = project.Status;

            await _context.SaveChangesAsync();

            return new ServiceResponse<Project> { Data = project };
        }

        public async Task<ServiceResponse<bool>> DeleteProject(int projectId)
        {
            var findProject = await _context.Projects.FindAsync(projectId);
            if (findProject == null)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Data = false,
                    Message = "Project not found."
                };
            }

            _context.Projects.Remove(findProject);
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true };
        }
    }
}