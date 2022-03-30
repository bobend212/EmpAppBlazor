using EmpAppBlazor.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace EmpAppBlazor.Server.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly DataContext _context;

        public ProjectService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Project>>> GetProjectsAsync()
        {
            var response = new ServiceResponse<List<Project>>()
            {
                Data = await _context.Projects.ToListAsync()
            };
            return response;    
        }
    }
}
