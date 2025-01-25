using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Services
{
    public interface IBookMenuService
    {
        void LoadMenu();
        void DisplayBook();
        void AddBook();
        void RemoveBook();
        void UpdateBook();
    }
}
