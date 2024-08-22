﻿using ConsoleAppProjectLibraryM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppProjectLibraryM.Model;
namespace ConsoleAppProjectLibraryM.Repository
{
    public interface IRepository
    {
        Task AddData(Book book);
        Task EditData1(string code, string Genre);
        Task EditData2(string code, string price);
        Task DeleteData(string Code);
        Task<Book> Search1(string Title);
        Task<Book> Search2(string Author);
    }
}
