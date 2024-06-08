using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;

namespace WebApplication11.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(DbNewsContextEntity context) : base(context)
        {
        }
    }
}