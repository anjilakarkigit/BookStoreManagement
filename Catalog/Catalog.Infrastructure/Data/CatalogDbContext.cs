using Catalog.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Data;

public class CatalogDbContext: DbContext
{
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options): base(options)
    {
        
    }
    
    // DbSets are properties of DbContext
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Publisher> Publishers{ get; set; }
}