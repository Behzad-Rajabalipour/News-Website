using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication11.Models;          // Add
/*
    To in Interface methodhaye jadid User ro inja minevisim,
    In interface farzande IGenericRepository<User> hast, chon age yek object azash sakhtim bazam male <User> bashe
    Example: IUserRepository obj = new UserRepository(){...};
*/
namespace WebApplication11.Repository
{
    internal interface IUserRepository: IGenericRepository<User>            // Chon T moshakhas hast, dige farzand lazem be <T> nadare
    {
    }
}
