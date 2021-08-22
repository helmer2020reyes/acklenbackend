using ACKLEN_API_BACKEND.Data.VM;
using ACKLEN_API_BACKEND.EntityModels;
using Microsoft.AspNetCore.Mvc;
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
        public Book UpdateBook(int id, BooksVM book)
        {
            var _book = _context.Books.Find(id);


            _book.Title = book.Title == null ? _book.Title : book.Title;
            _book.Description = book.Description == null ? _book.Description : book.Description;
//            _book.Isread = book.Isread == null ? _book.Isread : book.Isread;
            _book.Dateread = book.Dateread == null ? _book.Dateread : book.Dateread;
            _book.Rate = book.Rate == null ? _book.Rate : book.Rate;
            _book.Genre = book.Genre == null ? _book.Genre : book.Genre;
            _book.Author = book.Author == null ? _book.Author : book.Author;
            _book.Coverurl = book.Coverurl == null ? _book.Coverurl : book.Coverurl;

            _context.Books.Update(_book);
            _context.SaveChanges();
            return _book;
        }
        public List<Book> ListBooks()
        {
            var bk = _context.Books.ToList<Book>();

            return bk;
        }

    }
}
