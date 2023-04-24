using Catalog.ApplicationCore.Contracts.Repositories;
using Catalog.ApplicationCore.Entities;
using Catalog.Infrastructure.Data;

namespace Catalog.Infrastructure.Repositories;

public class BookRepository: BaseRepository<Book>, IBookRepository
{
    public BookRepository(CatalogDbContext dbContext) : base(dbContext)
    {
        
    }

    public  Author GetAuthorByName(string name)
    {
        return  _dbContext.Authors.FirstOrDefault(a => a.Name == name);
    }

    public Category GetCategoryByName(string name)
    {
        return  _dbContext.Categories.FirstOrDefault(a => a.CategoryName == name);
    }

    public Publisher GetPublisherByName(string name)
    {
        return  _dbContext.Publishers.FirstOrDefault(a => a.Name == name);
    }
}