using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Services
{
    public class LibrariantMenuService : ILibrariantMenuService
    {
        private readonly LibrariantService librariantService;

        public LibrariantMenuService()
        {
            this.librariantService = new LibrariantService();    
        }

        public void LoadMenu()
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
                    DisplayLibrariants(); break;
                case 2:
                    AddLibrariant(); break;

                case 3:
                    RemoveLibrariant(); break;
                case 4:
                    UpdateLibrariant(); break;
                case 5:
                    BackHome(); break;
            }
        }
        public void DisplayLibrariants()
        {
            var librariants = this.librariantService.RetrieveLibrariants();

            for(int index = 0; index < librariants.Count; index++)
                Console.WriteLine(index + 1 + ". " + 
                    $"{librariants[index].UserId}  {librariants[index].Name}  {librariants[index].Gender}  {librariants[index].BirthDate}  {librariants[index].Type}");
        }

        public void AddLibrariant()
        {
            Console.Clear();
            User librariant = new User();
            Console.WriteLine("==== Add a librariant ====");

            Console.Write("Id: ");
            librariant.UserId = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            librariant.Name = Console.ReadLine();

            Console.Write("Gender (0 - Male, 1 - Female): ");
            librariant.Gender = (Gender)int.Parse(Console.ReadLine());

            Console.Write("Birthday Date (yyyy-MM-dd): ");
            librariant.BirthDate = DateTime.Parse(Console.ReadLine());

            librariant.Type = UserType.Librariant;

            librariantService.AddLibrariant(librariant);
        }

        public void RemoveLibrariant()
        {
            Console.Clear();
            Console.WriteLine("==== Delete librariant ====");
            Console.Write("Enter librariant id: ");
            int.TryParse(Console.ReadLine(), out int id);

            librariantService.RemoveLibrariant(id);
        }

        public void UpdateLibrariant()
        {
            Console.Clear();
            Console.WriteLine("==== Updating librariant information ====");

            Console.Write("Enter librariant id: ");
            int.TryParse(Console.ReadLine(), out int id);

            var librariant = librariantService.RetriveLibrariant(id);

            Console.WriteLine($"{librariant.UserId}  {librariant.Name}  {librariant.Gender}  {librariant.BirthDate}  {librariant.Type}");
            this.RemoveLibrariant();
            this.AddLibrariant();
        }
        
        public void BackHome()
        {
            throw new NotImplementedException();
        }
    }
}
