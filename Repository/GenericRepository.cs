using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication11.Models;      // add
/*
    Repository haro ma faghat dakhele Service estefade mikonim
*/
namespace WebApplication11.Repository
{
    // chon valedesh <T> dare, pas farzand ham bayad dashte bashe
    // T typesh bayad az BaseEntity ya farzandash bashe
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity   // where T : class. public hast yani to WebApplication12 mitunim estefade konim
    {
        private DbNewsContextEntity db;         // in model entity be DB vasl hast
        private DbSet<T> dbSet;             // yek seti az type T. where T : class hatman bayad benevisim baraye in
        public GenericRepository(DbNewsContextEntity context) { 
            db = context;
            dbSet = context.Set<T>();          // mirizim ro dbSet, ke un dbSet<> khas ro dashte bashim, masaln dbSet<NewsGroups>
        }
        //-----------------------------
        // override baraye Interface IGenericRepository
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        public T GetEntity(int id)
        {
            return dbSet.Find(id);
        }

        public bool Add(T entity)
        {
            try
            {
                dbSet.Add(entity);          
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = dbSet.Find(id);
                db.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        //-----------------------------
        // override baraye Interface IDisposable
        public void Dispose()
        {
            db.Dispose();
        }


    }
}