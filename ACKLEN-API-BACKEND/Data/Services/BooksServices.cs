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
        public void DeleteBook(BooksVM book)
        {

           var elim= _context.Books.Find(book.Id);
            _context.Books.Remove(elim);
            _context.SaveChanges();

        }
        public void UpdateBook(BooksVM book)
        {
            var idbook = _context.Books.Find(book.Id);
            idbook.Id = book.Id;
            idbook.Title = book.Title;
            idbook.Description = book.Description;
            idbook.Isread = book.Isread;
            idbook.Dateread = book.Dateread;
            idbook.Rate = book.Rate;
            idbook.Genre = book.Genre;
            idbook.Author = book.Author;
            idbook.Coverurl = book.Coverurl;
            idbook.Dateadded = book.Dateadded;
            _context.Books.Update(idbook);
            _context.SaveChanges();
           
        }

    }
}
