using BookRent.Models;

namespace BookRent.Data.Interfaces
{
    public interface ILibrariantRepository
    {
        IList<User> SelectAllLibrariants();
        User SelectLibrariantById(int librariantId);
        User InsertLibrariant(User librariant);
        User UpdateLibrariant(int librariantId, User librariant);
        bool DeleteLibrariant(int librariantId);
    }
}
