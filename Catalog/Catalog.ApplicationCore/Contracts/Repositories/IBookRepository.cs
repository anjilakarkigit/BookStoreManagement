using Catalog.ApplicationCore.Entities;

namespace Catalog.ApplicationCore.Contracts.Repositories;

public interface IBookRepository:IBaseRepository<Book>
{
    Author GetAuthorByName(string name);
    Category GetCategoryByName(string name);
    Publisher GetPublisherByName(string name);
}