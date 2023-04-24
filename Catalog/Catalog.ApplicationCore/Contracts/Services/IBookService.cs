using System.Linq.Expressions;
using Catalog.ApplicationCore.Models;

namespace Catalog.ApplicationCore.Contracts.Services;

public interface IBookService
{
    Task<List<BookResponseModel>> GetAllBooks();
    Task<BookResponseModel> GetBookById(int id);
    Task<int> AddBook(BookRequestModel model);
}