using AutoMapper;
using EmpAppBlazor.Shared.DTOs;
using System.Collections;

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
    }
}