using BookRent.Data;
using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService()
        {
            this.bookRepository = new BookRepository();
        }
        public IList<Book> RetriveBooks(string name)
        {
            var books = this.bookRepository.SelectAllBooks();
            if (!string.IsNullOrEmpty(name))
            {
                List<Book> filteredBooks = new List<Book>();
                foreach (var book in books)
                    if(book.Name.Contains(name))
                        filteredBooks.Add(book);
                return filteredBooks;
            }
            return books;
        }

        public Book RetriveBook(int bookId)
        {
            Book book = null;

            try
            {
                book = this.bookRepository.SelectBookById(bookId);

                return book;
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            return book;
        }
        public Book AddBook(Book book)
        {
            Book insertedBook = null;

            try
            {
                insertedBook = this.bookRepository.InsertBook(book);

                return insertedBook;
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return insertedBook;
        }

        public Book ModifyBook(int bookId, Book book)
        {
            Book modifiedBook = null;

            try
            {
                modifiedBook = this.bookRepository.UpdateBook(bookId, book);

                return modifiedBook;
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return modifiedBook;
        }

        public bool RemoveBook(int bookId)
        {
            bool removedBook = false;

            try
            {
                removedBook = this.bookRepository.DeleteBook(bookId);

                return removedBook;
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return removedBook;
        }
    }
}
