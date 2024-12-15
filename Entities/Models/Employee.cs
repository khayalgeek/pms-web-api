using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Employee
{
    [Column("ID")]
    public int Id { get; set; }
    
    [Column("NAME")]
    [Required(ErrorMessage = "Name is required")]
    public string Name{ get; set; }
    
    [Column("SURNAME")]
    [Required(ErrorMessage = "Surname is required")]
    public string Surname { get; set; }
    
    [Column("BIRTHDAY")]
    [Required(ErrorMessage = "Birthday is required")]
    public DateTime Birthday { get; set; }
    
    [Column("POSITION")]
    public string? Position { get; set; } 
    
    [ForeignKey(nameof(Position))]
    [Column("PROJECT_ID")]
    public Guid? ProjectId { get; set; } //FK
    public Project Project { get; set; } //Navigation property
}