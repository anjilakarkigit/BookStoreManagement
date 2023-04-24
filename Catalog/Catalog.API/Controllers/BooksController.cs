using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.ApplicationCore.Contracts.Services;
using Catalog.ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    //Attribute Routing
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        //get all books
        [HttpGet("")]
        public async Task<IActionResult> GetAllBooks ()
        {
            var books = await _bookService.GetAllBooks();
            return Ok(books);
        }
        
        [HttpGet]
        [Route("{id:int}", Name = "GetBookDetails")]
        public async Task<IActionResult> GetBookDetails(int id)
        {
            var book = await _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound(new { errorMessage = "No book found for this id" });
            }

            return Ok(book);
        }
        
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Create(BookRequestModel model)
        {
            if (!ModelState.IsValid)
                // 400 status code
                return BadRequest();

            var book = await _bookService.AddBook(model);
            return CreatedAtAction
                ("GetBookDetails", new { controller = "Books", id = book }, "Job Created");
        }
        
    }
}
