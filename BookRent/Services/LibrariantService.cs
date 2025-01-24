
using BookRent.Data;
using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Services
{
    public class LibrariantService : ILibrariantService
    {
        private readonly ILibrariantRepository librariantRepository;

        public LibrariantService()
        {
            this.librariantRepository = new LibrariantRepository();
        }

        public IEnumerable<User> RetriveLibrariants(string name)
        {
            var librariants = this.librariantRepository.SelectAllLibrariants();

            if (!string.IsNullOrEmpty(name))
            {
                var filteredLibrariants = new List<User>();

                foreach(var librariant in librariants)
                    if (librariant.Name.Contains(name))
                        filteredLibrariants.Add(librariant);

                return filteredLibrariants;
            }

            return librariants;
        }

        public User RetriveLibrariant(int librariantId)
        {
            User librariant = null;

            try
            {
                librariant = this.librariantRepository.SelectLibrariantById(librariantId);

                return librariant;
            }
            catch (KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return librariant;
        }

        public User AddLibrariant(User librariant)
        {
            User insertedLibrariant = null;

            try
            {
                insertedLibrariant = this.librariantRepository.InsertLibrariant(librariant);
            }
            catch(ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return insertedLibrariant;
        }

        public User ModifyLibrariant(int librariantId, User librariant)
        {
            User modifiedLibrariant = null;

            try
            {
                modifiedLibrariant = this.librariantRepository.UpdateLibrariant(librariantId, librariant);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(TimeoutException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return modifiedLibrariant;
        }

        public bool RemoveLibrariant(int librariantId)
        {
            bool isRemoved = false;

            try
            {
                isRemoved = this.librariantRepository.DeleteLibrariant(librariantId);
            }
            catch(KeyNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return isRemoved;
        }
    }
}
