namespace Catalog.ApplicationCore.Models;

public class BookResponseModel
{
    public int BookId { get; set; }
    public string AuthorName { get; set; }
    public long ISBN { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string? synopsis { get; set; }
    public DateOnly? PublicationDate { get; set; }

}