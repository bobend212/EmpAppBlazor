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
        public async Task<ServiceResponse<List<ProjectGetDTO>>> GetProjects()
        {
            var projects = await _context.Projects.Include(w => w.Workload).ThenInclude(x => x.DesignLeader).Include(x => x.UserProjects).ThenInclude(x => x.User).ToListAsync();
            var projectsDto = _mapper.Map<List<ProjectGetDTO>>(projects);

            var response = new ServiceResponse<List<ProjectGetDTO>>()
            {
                Data = projectsDto
            };
            return response;
        }

        public async Task<ServiceResponse<List<ProjectGetDTO>>> GetProjectsByWorkloadStage(string stageWorkload)
        {
            var projects = await _context.Projects.Include(w => w.Workload).ThenInclude(x => x.DesignLeader).Include(x => x.UserProjects).ThenInclude(x => x.User).Where(x => x.Workload.ProductionStage.ToLower().Equals(stageWorkload.ToLower())).ToListAsync();
            var projectsDto = _mapper.Map<List<ProjectGetDTO>>(projects);

            var response = new ServiceResponse<List<ProjectGetDTO>>()
            {
                Data = projectsDto
            };
            return response;
        }

        public async Task<ServiceResponse<ProjectGetDTO>> GetSingleProject(int projectId)
        {
            var response = new ServiceResponse<ProjectGetDTO>();
            var project = await _context.Projects.Include(w => w.Workload).ThenInclude(x => x.DesignLeader).Include(x => x.UserProjects).ThenInclude(x => x.User).FirstOrDefaultAsync(x => x.Id == projectId);
            var projectDto = _mapper.Map<ProjectGetDTO>(project);

            if (project == null)
            {
                response.Success = false;
                response.Message = "This project does not exist.";
            }
            else
            {
                response.Data = projectDto;
            }

            return response;
        }

        public async Task<ServiceResponse<bool>> CreateProject(ProjectAddDTO project)
        {
            var projectDto = _mapper.Map<Project>(project);
            _context.Projects.Add(_mapper.Map<Project>(projectDto));
            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Message = "Project Created", Data = true };
        }

        public async Task<ServiceResponse<bool>> UpdateProject(ProjectUpdateDTO project)
        {
            var findProject = await _context.Projects.FindAsync(project.Id);
            if (findProject == null)
            {
                return new ServiceResponse<bool>()
                {
                    Success = false,
                    Message = "Project not found.",
                    Data = false
                };
            }

            findProject.Number = project.Number;
            findProject.Name = project.Name;
            findProject.Site = project.Site;
            findProject.Status = project.Status;

            await _context.SaveChangesAsync();

            return new ServiceResponse<bool> { Message = "Project Updated", Data = true };
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

            return new ServiceResponse<bool> { Message = "Project Deleted", Data = true };
        }
    }
}