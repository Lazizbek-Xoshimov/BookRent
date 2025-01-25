using BookRent.View;

namespace BookRent.Services
{
    public class HomeService : IHomeService
    {
        public ILibrariantConsoleView librariantConsoleView;
        public IBookConsoleView bookConsoleView;

        public HomeService()
        {
            this.librariantConsoleView = new LibrariantConsoleView();
            this.bookConsoleView = new BookConsoleView();
        }

        public void LoadExistingMenus()
        {
            Console.Clear();
            var menus = "1. Librariants\n2. Books\n3. Teachers\n4. Exit";
            Console.WriteLine("==== Menu ====");
            Console.WriteLine(menus);

            Console.Write("\n\nSelect menu: ");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1: 
                    LoadLibraryMenu(); break;
                case 2:
                    LoadBookMenu(); break;
                case 3:
                    TeachersMenu(); break;
                case 4:
                    Exit(); break;
            }
        }


        public void LoadBookMenu()
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
                    bookConsoleView.DisplayBook(); break;
                case 2:
                    bookConsoleView.AddBook(); break;
                case 3:
                    bookConsoleView.RemoveBook(); break;
                case 4:
                    bookConsoleView.UpdateBook(); break;
                case 5:
                    LoadExistingMenus(); break;
            }
        }


        public void LoadLibraryMenu()
        {
            Console.Clear();
            var menus = "1. List of librariants\n2. Add a librariant\n3. Delete librariant\n4. Updating librarian information\n5. Back";
            Console.WriteLine("==== Librariants ====");
            Console.WriteLine(menus);

            Console.Write("\n\nMenu tanlang: ");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    librariantConsoleView.DisplayLibrariants(); break;
                case 2:
                    librariantConsoleView.AddLibrariant(); break;

                case 3:
                    librariantConsoleView.RemoveLibrariant(); break;
                case 4:
                    librariantConsoleView.UpdateLibrariant(); break;
                case 5:
                    LoadExistingMenus(); break;
            }
        }
        private void TeachersMenu()
        {

        }

        private void Exit()
        {
            Environment.Exit(0);
        }
    }
}
