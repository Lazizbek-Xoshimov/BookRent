using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Services
{
    public class BookMenuService : IBookMenuService
    {
        private readonly IBookService bookService;

        public BookMenuService()
        {
            this.bookService = new BookService();
        }

        public void LoadMenu()
        {
            Console.Clear();
            var menus = "1. List of books\n2. Add a book\n3. Delete book\n4. Updating book information\n5. Back";
            Console.WriteLine("==== Books ====");
            Console.WriteLine(menus);

            Console.Write("\n\nSelect menu: ");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    DisplayBook(); break;
                case 2:
                    AddBook(); break;
                case 3: 
                    RemoveBook(); break;
                case 4:
                    UpdateBook(); break;
                case 5:
                    Back(); break;
            }
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
        public void Back()
        {
            throw new NotImplementedException();
        }
    }
}
