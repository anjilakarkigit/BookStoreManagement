using Catalog.ApplicationCore.Contracts.Repositories;
using Catalog.ApplicationCore.Contracts.Services;
using Catalog.Infrastructure.Data;
using Catalog.Infrastructure.Repositories;
using Catalog.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
//Inject our ConnectionString into DbContext
builder.Services.AddDbContext<CatalogDbContext>(
     options => options.UseSqlServer(builder.Configuration.GetConnectionString("CatalogDbConnection"))
 );
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();