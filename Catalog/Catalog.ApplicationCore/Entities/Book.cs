
using System.ComponentModel.DataAnnotations;

namespace Catalog.ApplicationCore.Entities;

public class Book
{
    public int BookId { get; set; }
    
    [Required]
    [MaxLength(80)]
    public string AuthorName { get; set; }

    public long ISBN { get; set; }
    
    [MaxLength(80)]
    [Required]
    public string Title { get; set; }
    
    public DateOnly? PublicationDate { get; set; }
    
    [MaxLength(80)]
    public string Genre { get; set; }
    
    public string? synopsis { get; set; }
    
    // Foreign key properties
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    
    public int PublisherId { get; set; }
    public Publisher Publisher { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    
}