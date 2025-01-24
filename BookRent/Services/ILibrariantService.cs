using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Services
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
