using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication11.Models;
/*
    To in Interface methodhaye jadid <T> yani(User,NewsGroups,News,Comment) ro inja minevisim,
*/
/*
    Repository haro ma faghat dakhele Service estefade mikonim
*/
namespace WebApplication11.Service
{
    // hameye farzandhaye BaseEntity ham mishe 
    internal interface IGenericService<T> where T : BaseEntity  //  Internal hast yani to WebApplication12 mostaghim nemitunim az in Interface besazim
    {
    }
}
