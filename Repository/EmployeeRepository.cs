using Contracts;
using Entities.Models;

namespace Repository;

public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository{
    public EmployeeRepository(RepositoryContext dbContext) : base(dbContext)
    {
    }

    public IEnumerable<Employee> GetEmployeesByProjectId(Guid projectId, bool trackChanges) =>
        FindByCondition(e=>e.Project.Equals(projectId), trackChanges)
            .OrderBy(e=>e.Name)
            .ToList();
   

    public Employee GetEmployeeByProjectId(Guid projectId, Guid id, bool trackChanges) =>
        FindByCondition(e => e.ProjectId.Equals(projectId) && e.Id.Equals(id), trackChanges)
            .SingleOrDefault();
   

    public void CreateEmployeeForProjectId(Guid projectId, Employee employee)
    {
        employee.ProjectId = projectId;
        Create(employee);
    }

    public void UpdateEmployee(Employee employee) => 
        Update(employee);
   

    public void DeleteEmployee(Employee employee) => 
        Delete(employee);
   
} 