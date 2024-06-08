using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    To in Interface methodhaye jadid <T> yani(User,NewsGroups,News,Comment) ro inja minevisim,
*/
/*
    Repository haro ma faghat dakhele Service estefade mikonim
*/
namespace WebApplication11.Repository
{
    // chon farzande IDisposable ham hast, bayad override baraye har 2ta Interface benevise
    internal interface IGenericRepository<T> : IDisposable      // IDisposable. Internal hast yani to WebApplication12 mostaghim nemitunim az in Interface besazim
    {
        IEnumerable<T> GetAll();            // listi az type T
        T GetEntity(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Delete(int id);
        void Save();
    }
}
