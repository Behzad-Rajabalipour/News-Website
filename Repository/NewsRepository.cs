using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;

namespace WebApplication11.Repository
{
    public class NewsRepository : GenericRepository<News>, INewsRepository
    {
        public NewsRepository(DbNewsContextEntity context) : base(context)
        {
        }
    }
}