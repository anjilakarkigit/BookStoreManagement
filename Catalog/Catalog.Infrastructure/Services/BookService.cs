using Catalog.ApplicationCore.Contracts.Repositories;
using Catalog.ApplicationCore.Contracts.Services;
using Catalog.ApplicationCore.Entities;
using Catalog.ApplicationCore.Models;

namespace Catalog.Infrastructure.Services;

public class BookService:IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<List<BookResponseModel>> GetAllBooks()
    {
        var books = await _bookRepository.GetAllAsync();
        var bookResponseModel = new List<BookResponseModel>();
        foreach (var book in books)
        {
            bookResponseModel.Add(new BookResponseModel
            {
                BookId = book.BookId,
                AuthorName= book.AuthorName, 
                ISBN = book.ISBN,
                Title = book.Title,
                Genre = book.Genre
            });
        }

        return bookResponseModel;
    }

    public async Task<BookResponseModel> GetBookById(int id)
    {
        var book = await _bookRepository.GetByIdAsync(id);

        if (book == null)
        {
            return null;
        }

        var bookResponseModel = new BookResponseModel
        {
            BookId = book.BookId,
            AuthorName= book.AuthorName, 
            ISBN = book.ISBN,
            Title = book.Title,
            Genre = book.Genre
        };
        return bookResponseModel;
    }

    public async Task<int> AddBook(BookRequestModel model)
    {
        // Look up the author entity by name
        var author =  _bookRepository.GetAuthorByName(model.AuthorName);
        var publisher =  _bookRepository.GetPublisherByName(model.PublisherName);
        var category = _bookRepository.GetCategoryByName(model.CategoryName);
        if (author == null || publisher == null || category == null)
        {
            throw new InvalidOperationException("Author or Publisher or Category Not found.");
        }

        var bookEntity = new Book
        {
            AuthorName = model.AuthorName,
            ISBN = model.ISBN,
            Title = model.Title,
            Genre = model.Genre,
            AuthorId = author.AuthorId,
            PublisherId = publisher.PublisherId,
            CategoryId = category.CategoryId
        };
        var book = _bookRepository.AddAsync(bookEntity);
        return book.Id;

    }
}