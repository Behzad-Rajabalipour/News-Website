using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication11.Models;      // add
using WebApplication11.Repository;  // add

namespace WebApplication11.Service
{
    internal interface INewsService : IGenericService<News>     // Internal hast yani to WebApplication12 mostaghim nemitunim az in Interface besazim
    {
        List<News> getLastNewsList(int? count);
        List<News> getBestNewsList(int count);
        List<News> getAllNewsList();
        News getlastNews();

    }
}
