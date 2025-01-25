using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Data
{
    public class BookRepository : IBookRepository
    {
        Dictionary<int, Book> books;

        public BookRepository()
        {
            this.books = new Dictionary<int, Book>();
        }

        public Book SelectBookById(int bookId)
        {
            if(!this.books.ContainsKey(bookId))
                throw new KeyNotFoundException("Book not found. ");
            return this.books[bookId];
        }

        public IList<Book> SelectAllBooks() =>
            this.books.Values.ToList();

        public Book InsertBook(Book book)
        {
            if (books.ContainsKey(book.BookId))
                throw new ArgumentException("Librariant with this key already exists.");

            books.Add(book.BookId, book);

            return book;
        }

        public Book UpdateBook(int bookId, Book book)
        {
            if(!books.ContainsKey(bookId))
                throw new KeyNotFoundException("Book not found.");

            var excitingBook = books[bookId];

            if (string.IsNullOrEmpty(book.Name))
                throw new ArgumentNullException("book.Name cannot be null.");

            excitingBook.Name = book.Name;

            if(string.IsNullOrEmpty(book.Author))
                throw new ArgumentNullException("book.Author cannot be null.");

            excitingBook.Author = book.Author;

            excitingBook.Version = book.Version;

            return excitingBook;
        }

        public bool DeleteBook(int bookId)
        {
            if(!books.ContainsKey(bookId))
                throw new KeyNotFoundException("Book not found.");
            return books.Remove(bookId);
        }
    }
}
