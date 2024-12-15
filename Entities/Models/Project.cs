using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Project
{
    [Column("ID")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Project name is required")]
    [MaxLength(50, ErrorMessage = "Project name cannot be more than 50 characters")]
    [Column("NAME")]
    public string Name { get; set; }
    
    [Column("DESCRIPTION")]
    public string? Description { get; set; }
    
    [Column("FIELD")]
    public string? Field { get; set; }
    
    [Column("IMAGE_URL")]
    public string? ImageUrl { get; set; }
    
    public ICollection<Employee> Employees { get; set; }
    
}