using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;

namespace WebApplication11.Repository
{
    public class NewsGroupRepository : GenericRepository<NewsGroup>, INewsGroupRepository
    {
        public NewsGroupRepository(DbNewsContextEntity context) : base(context)
        {
        }
    }
}