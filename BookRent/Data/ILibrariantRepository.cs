﻿using BookRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRent.Data
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
