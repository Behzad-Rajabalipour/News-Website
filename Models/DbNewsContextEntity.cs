using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;                   // NutGet => install Microsoft.AspNet.Web.Optimization

namespace WebApplication11.Models
{
    // har tabli ke inja benevisi, faghat migrate mishe va be db vasl mishe
    public class DbNewsContextEntity: DbContext
    {
        public DbSet<News> News { get; set;}                // Table News sakhte mishe to db
        public DbSet<NewsGroup> NewsGroups { get; set; }     // Table NewsGroup sakhte mishe to db
        public DbSet<User> Users { get; set;}               //
        public DbSet<Comment> Comments { get; set;}         //
    }
}