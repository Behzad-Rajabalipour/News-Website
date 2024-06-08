using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;      // add
using WebApplication11.Repository;  // add

/*
    Repository haro ma faghat dakhele Service estefade mikonim
*/
namespace WebApplication11.Service
{
    public class GenericService<T> : GenericRepository<T> where T : BaseEntity  // public hast yani to WebApplication12 mitunim estefade konim
    {
        public GenericService(DbNewsContextEntity context) : base(context)
        {
        }
    }
}