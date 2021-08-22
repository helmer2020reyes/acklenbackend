using ACKLEN_API_BACKEND.Data.VM;
using ACKLEN_API_BACKEND.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACKLEN_API_BACKEND.Data.Services
{
    public class BooksServices
    {
        private postgresContext _context;

        public BooksServices(postgresContext context)
        {
            _context = context;
        }



        public void AddBook(BooksVM book)
        {
            var bok = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                Isread = book.Isread,
                Dateread = book.Isread ? book.Dateread.Value:null,
                Rate= book.Isread ? book.Rate.Value:null,
                Genre=book.Genre,
                Author=book.Author,
                Coverurl=book.Coverurl,
                Dateadded=DateTime.Now,
                

            };
            _context.Books.Add(bok);
            _context.SaveChanges();

        }
    }
}
