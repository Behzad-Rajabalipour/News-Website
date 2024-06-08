using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication11.Models;
/*
    To in Interface methodhaye jadid User ro inja minevisim,
    In interface farzande IGenericService<User> hast, chon age yek object azash sakhtim bazam male <User> bashe
    Example: IUserService obj = new UserService(){...};
*/
namespace WebApplication11.Service
{
    internal interface IUserService : IGenericService<User>
    {
        int GetUserId(string MobileNUmber);
    }
}
