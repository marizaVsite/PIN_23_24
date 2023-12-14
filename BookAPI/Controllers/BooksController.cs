using BookAPI.Data;
using BookAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService BooksService { get; set; }
        public BooksController(BooksService booksService)
        {
            BooksService = booksService;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] BookVM book)
        {
            BooksService.AddBook(book);
            return Ok();
        }


        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var allBooks= BooksService.GetAllBooks();
            return Ok(allBooks);
        }


        [HttpGet("id")]
        public IActionResult GetBookById([FromQuery]int id)
        {
            var book = BooksService.GetBookById(id);
            return Ok(book);
        }

        [HttpPut("id")]
        public IActionResult UpdateBookById([FromQuery] int id, [FromBody]BookVM bookVM)
        {
            var updatedBook= BooksService.UpdateBookById(id, bookVM);
            return Ok(updatedBook);
        }

        [HttpDelete("id")]
        public IActionResult DeleteBook([FromQuery] int id)
        {
            BooksService.DeleteBook(id);
            return Ok();
        }


    }
}
