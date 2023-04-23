using System.ComponentModel.DataAnnotations;

namespace Catalog.ApplicationCore.Entities;

public class Category
{
    public int CategoryId { get; set; }
    
    [MaxLength(150)]
    [Required]
    public string CategoryName { get; set; }
    
    public string? CategoryDescription{ get; set; }
    
}