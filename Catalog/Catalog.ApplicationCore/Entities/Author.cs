using System.ComponentModel.DataAnnotations;

namespace Catalog.ApplicationCore.Entities;

public class Author
{
    public int AuthorId { get; set; }
    
    [MaxLength(80)]
    [Required]
    public string Name { get; set; }
    
    public DateOnly? DateOfBirth { get; set; }
    
    public DateOnly? DateOfDeath { get; set; }
    
    [MaxLength(80)]
    public string Nationality { get; set; }
    
    [MaxLength(2000)]
    public string? Biography { get; set; }
    
    [MaxLength(80)]
    public string ContactInfo { get; set; }
}