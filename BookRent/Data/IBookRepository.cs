using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Data
{
    public interface IBookRepository
    {
        IList<Book> SelectAllBooks();
        Book SelectBookById(int bookId);
        Book InsertBook(Book book);
        Book UpdateBook(int bookId, Book book);
        bool DeleteBook(int bookId);
    }
}
