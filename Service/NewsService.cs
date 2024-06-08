using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;      // add
using WebApplication11.Repository;  // add

namespace WebApplication11.Service
{
    public class NewsService : GenericService<News>, INewsService   // public hast yani to WebApplication12 mitunim estefade konim
    {
        NewsRepository _newsRepository;             // Repository hao faghat dakhele Sevice estefade mikonim
        public NewsService(DbNewsContextEntity context) : base(context)
        {
            _newsRepository = new NewsRepository(context);
        }

        public List<News> getLastNewsList(int? count)
        {
            return _newsRepository.GetAll().Where(t => t.IsActive).OrderByDescending(u => u.NewsId).Take(count.Value).ToList();         // vaghti ?(null) darim, bayad .Value befrestim
        }
        public List<News> getBestNewsList(int count)
        {
            return _newsRepository.GetAll().Where(t => t.IsActive).OrderByDescending(u => u.See).Take(count).ToList();
        }
        public List<News> getAllNewsList()
        {
            return _newsRepository.GetAll().Where(t => t.IsActive).OrderByDescending(t => t.RegisterDate).ToList();
        }

        public News getlastNews()
        {
            return _newsRepository.GetAll().Where(t => t.IsActive).LastOrDefault();
        }
    }
}