using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.View
{
    public interface IBookConsoleView
    {
        void DisplayBook();
        void AddBook();
        void RemoveBook();

        void UpdateBook();
    }
}
