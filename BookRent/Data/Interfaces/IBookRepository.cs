using BookRent.Models;

namespace BookRent.Data.Interfaces
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
