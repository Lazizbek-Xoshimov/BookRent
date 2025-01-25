using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Services
{
    public class HomeService : IHomeService
    {
        public ILibrariantMenuService librariantMenuService;
        public IBookMenuService bookMenuService;

        public HomeService()
        {
            this.librariantMenuService = new LibrariantMenuService();
            this.bookMenuService = new BookMenuService();
        }

        public void LoadExistingMenus()
        {
            var menus = "1. Librariants\n2. Books\n3. Teachers\n4. Exit";
            Console.WriteLine("==== Menu ====");
            Console.WriteLine(menus);

            Console.Write("\n\nSelect menu: ");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1: 
                    librariantMenuService.LoadMenu(); break;
                case 2:
                    bookMenuService.LoadMenu(); break;
                case 3:
                    TeachersMenu(); break;
                case 4:
                    Exit(); break;
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
