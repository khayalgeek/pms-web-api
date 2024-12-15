using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Project = Entities.Models.Project;

namespace PMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private ILoggerManager _loggerManager;
            
        public ProjectsController(ILoggerManager loggerManager)
        {
           _loggerManager = loggerManager;
        }
       private readonly List<Project> _projects = new()
       {
           new Project{Id = Guid.NewGuid(), Name = "Project 1"},
           new Project{Id = Guid.NewGuid(), Name = "Project 2"},
           new Project{Id = Guid.NewGuid(), Name = "Project 3"}
       };

       [HttpGet]
       public IActionResult Get()
       {
           try
           {
               
               _loggerManager.LogInfo("Get all projects");
               return Ok(_projects);
           }
           catch (Exception e)
           {
              _loggerManager.LogError(e.Message);
               throw;
           }
       }
    }
}
