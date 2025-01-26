using BookRent.Models;

public interface IBookService
{
    IList<Book> RetriveBooks(string name = null);
    Book RetriveBook(int bookId);
    Book AddBook(Book book);
    Book ModifyBook(int bookId, Book book);
    bool RemoveBook(int bookId);
}
