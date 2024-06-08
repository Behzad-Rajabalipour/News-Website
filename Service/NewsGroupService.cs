using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;
using WebApplication11.Repository;

/*
    Repository haro ma faghat dakhele Service estefade mikonim
*/
namespace WebApplication11.Service
{
    public class NewsGroupService : GenericService<NewsGroup>, INewsGroupService
    {
        // chon private hast pas db leak nemishe to farzandash
        private INewsGroupRepository _newsGroupRepository;
        public NewsGroupService(DbNewsContextEntity context) : base(context)
        {
            _newsGroupRepository = new NewsGroupRepository(context);        // haminjutri ke context ro dari mibari bala be ma ham bede
        }

        public int NextNewsGroupId()
        {
            int max = 1;
            if (_newsGroupRepository.GetAll().ToList().Count > 0)
            {
                max = _newsGroupRepository.GetAll().Max(t => t.NewsGroupId) + 1;
            }
            return max;
        }

        // Age protected db, dbSet dashtim, injuri ham mishod
        //public int NextNewsGroupId()
        //{
        //    int max = 1;
        //    if (dbSet.ToList().Count > 0)
        //    {
        //        max = dbSet.ToList().Max(t => t.NewsGroupId) + 1;    // chon dbSet to parent, protected hast, pas inja estefade mikonim
        //    }
        //    return max;
        //}
    }
}