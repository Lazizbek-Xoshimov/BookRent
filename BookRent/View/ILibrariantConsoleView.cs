using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.View
{
    public interface ILibrariantConsoleView
    {
        void DisplayLibrariants();
        void AddLibrariant();
        void RemoveLibrariant();
        void UpdateLibrariant();
    }
}
