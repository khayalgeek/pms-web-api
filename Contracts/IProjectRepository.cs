using Entities.Models;

namespace Contracts;

public interface IProjectRepository
{
    IEnumerable<Project> GetAllProjects(bool trackChanges);
    Project? GetProjectById(Guid projectId, bool trackChanges);
    void CreateProject(Project project);
    void UpdateProject(Project project);
    void DeleteProject(Project project);
}