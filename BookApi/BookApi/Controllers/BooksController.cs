using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly Book[] _book = new Book[]
        {
            new() {Id = 1, Title = "Book 1", Author = "Author 1"},
            new() {Id = 2, Title = "Book 2", Author = "Author 2"},
            new() {Id = 3, Title = "Book 3", Author = "Author 3"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return Ok(_book);
        }
    }
}
