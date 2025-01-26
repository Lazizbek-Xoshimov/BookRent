using BookRent.Data.Interfaces;
using BookRent.Models;

namespace BookRent.Data
{
    public class LibrariantRepository : ILibrariantRepository
    {
        private Dictionary<int, User> librariants;

        public LibrariantRepository()
        {
            this.librariants = new Dictionary<int, User>();
        }

        public User SelectLibrariantById(int librariantId)
        {
            if (!librariants.ContainsKey(librariantId))
                throw new KeyNotFoundException("Librariant not found.");

            return librariants[librariantId];
            
        }

        public IList<User> SelectAllLibrariants() =>
             librariants.Values.ToList();

        public User InsertLibrariant(User librariant)
        {
            if (librariants.ContainsKey(librariant.UserId))
                throw new ArgumentException("Librariant with this key already exists.");

            librariants.Add(librariant.UserId, librariant);

            return librariant;
        }

        public User UpdateLibrariant(int librariantId, User librariant)
        {
            if (!librariants.ContainsKey(librariantId))
                throw new KeyNotFoundException("Librariant not found.");

            var exictingLibrariant = librariants[librariantId];

            if(string.IsNullOrEmpty(librariant.Name))
                throw new ArgumentNullException("librariant.Name cannot be null.");

            exictingLibrariant.Name = librariant.Name;
            
            exictingLibrariant.Gender = librariant.Gender;

            if(librariant.BirthDate < DateTime.Now)
                throw new TimeoutException("BirthDate cannot be DateTime.Now");

            exictingLibrariant.BirthDate = DateTime.Now;

            exictingLibrariant.Type = librariant.Type;

            return exictingLibrariant;
        }
        public bool DeleteLibrariant(int librariantId)
        {
            if (!librariants.ContainsKey(librariantId))
                throw new KeyNotFoundException("Librariant not found.");

            return librariants.Remove(librariantId);
        }
    }
}
