using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;
/*
    GenericRepository<User> : Parent class hast ke method hasho be UserRepository mide.
    IUserRepository : Parent Interface hast, ke age methode parent jadid khasti unja benevisi
*/
namespace WebApplication11.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbNewsContextEntity context) : base(context)
        {
        }
    }
}