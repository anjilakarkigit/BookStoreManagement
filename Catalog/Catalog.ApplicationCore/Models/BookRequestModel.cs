namespace Catalog.ApplicationCore.Models;

public class BookRequestModel
{
    public string AuthorName { get; set; }
    public string CategoryName { get; set; }
    public string PublisherName { get; set; }
    public long ISBN { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string? synopsis { get; set; }
    public DateOnly? PublicationDate { get; set; }
    
}