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
        IEnumerable<User> RetriveLibrariants(string name);
        User RetriveLibrariant(int librariantId);
        User AddLibrariant(User librariant);
        User ModifyLibrariant(int librariantId, User librariant);
        bool RemoveLibrariant(int librariantId);
    }
}
