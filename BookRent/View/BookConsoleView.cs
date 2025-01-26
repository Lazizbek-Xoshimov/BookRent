using BookRent.Models;
using BookRent.Services;
using BookRent.View.Interfaces;

namespace BookRent.View
{
    public class BookConsoleView : IBookConsoleView
    {
        private readonly IBookService bookService;

        public BookConsoleView()
        {
            this.bookService = new BookService();
        }

        public void DisplayBook()
        {
            var books = this.bookService.RetriveBooks();
            Console.WriteLine("==== List of books ====");
            for (int index = 0; index < books.Count; index++)
            {
                Console.WriteLine(index + 1 + $"{books[index].BookId}  {books[index].Name}  {books[index].Author}  {books[index].Version}");
            }
        }
        public void AddBook()
        {
            Console.Clear();
            Book book = new Book();
            Console.WriteLine("==== Add a book ====");

            Console.Write("Id: ");
            book.BookId = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            book.Name = Console.ReadLine();

            Console.Write("Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Version: ");
            book.Version = int.Parse(Console.ReadLine());

            bookService.AddBook(book);
        }
        public void UpdateBook()
        {
            Console.Clear();
            Console.WriteLine("==== Updating book information ====");

            Console.Write("Enter librariant id: ");
            int.TryParse(Console.ReadLine(), out int id);

            var book = bookService.RetriveBook(id);

            Console.WriteLine($"{book.BookId}  {book.Name}  {book.Author}  {book.Version}");
            this.RemoveBook();
            this.AddBook();
        }
        public void RemoveBook()
        {
            Console.Clear();
            Console.WriteLine("==== Delete book ====");
            Console.Write("Enter librariant id: ");
            int.TryParse(Console.ReadLine(), out int id);

            bookService.RemoveBook(id);
        }
    }
}
