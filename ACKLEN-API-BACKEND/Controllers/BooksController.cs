using ACKLEN_API_BACKEND.Data.Services;
using ACKLEN_API_BACKEND.Data.VM;
using ACKLEN_API_BACKEND.EntityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACKLEN_API_BACKEND.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private BooksServices _context;

        public BooksController(BooksServices context)
        {
            _context = context;

        }

        [HttpPost]
        public IActionResult AddBook([FromBody]BooksVM book)
        {
            _context.AddBook(book);
            return Ok();

        }
        [HttpDelete]
        public IActionResult Deletebook([FromBody]BooksVM book)
        {
            _context.DeleteBook(book);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook([FromBody]BooksVM book,int id)
        {
            
            _context.UpdateBook(id, book);
            return Ok();
        }

        [HttpGet]
        public ActionResult< List<Book> > ListBooks()
        {
            return _context.ListBooks();
        }

        
    }
}
