using BookRent.Models;

namespace BookRent.Services.Interfaces
{
    public interface ILibrariantService
    {
        IList<User> RetrieveLibrariants(string name = null);
        User RetriveLibrariant(int librariantId);
        User AddLibrariant(User librariant);
        User ModifyLibrariant(int librariantId, User librariant);
        bool RemoveLibrariant(int librariantId);
    }
}
