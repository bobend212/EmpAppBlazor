using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpAppBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Number = 17156,
                Name = "Tomason",
                Site = "Self-Build",
                Description = "",
                DeliveryDate = DateTime.Now.AddDays(5),
            },
            new Project
            {
                Id = 2,
                Number = 14104,
                Name = "Ellesar",
                Site = "Self-Build",
                Description = "",
                DeliveryDate = DateTime.Now.AddDays(35),
            },
            new Project
            {
                Id = 3,
                Number = 21201,
                Name = "Clark",
                Site = "KTS",
                Description = "This project is on hold now.",
                DeliveryDate = DateTime.Now.AddDays(4),
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetProjects()
        {
            return Ok(Projects);
        }
    }
}
