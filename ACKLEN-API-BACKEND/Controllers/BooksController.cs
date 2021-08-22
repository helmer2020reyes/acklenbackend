using ACKLEN_API_BACKEND.Data.Services;
using ACKLEN_API_BACKEND.Data.VM;
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

        [HttpPut]
        public IActionResult UpdateBook([FromBody]BooksVM books)
        {
            _context.UpdateBook(books);
            return Ok();
        }
        
    }
}
