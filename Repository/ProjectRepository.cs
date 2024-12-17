using Contracts;
using Entities.Models;

namespace Repository;

public class ProjectRepository: RepositoryBase<Project>, IProjectRepository
{
    public ProjectRepository(RepositoryContext dbContext) : base(dbContext)
    {
    }

    public IEnumerable<Project> GetAllProjects(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(p=>p.Name)
            .ToList();

    public Project? GetProjectById(Guid projectId, bool trackChanges) =>
        FindByCondition(p=>p.Id.Equals(projectId), trackChanges)
            .SingleOrDefault();

    public void CreateProject(Project project) => 
        Create(project);

    public void UpdateProject(Project project) =>
        Update(project);
   
    public void DeleteProject(Project project) => 
        Delete(project);
}