using System.ComponentModel.DataAnnotations;

namespace Catalog.ApplicationCore.Entities;

public class Publisher
{
    public int PublisherId { get; set; }
    
    [MaxLength(80)]
    [Required]
    public string Name { get; set; }
    
    [MaxLength(200)]
    public string? Address { get; set; }
    
    [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$")]
    [Required]
    public string phone { get; set; }
    
    [MaxLength(500)]
    public string Description { get; set; }
    
    public string? Website { get; set; }
}