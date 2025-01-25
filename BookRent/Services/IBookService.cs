using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Services
{
    public interface IBookService
    {
        IList<Book> RetriveBooks(string name = null);
        Book RetriveBook(int bookId);
        Book AddBook(Book book);
        Book ModifyBook(int bookId, Book book);
        bool RemoveBook(int bookId);
    }
}
