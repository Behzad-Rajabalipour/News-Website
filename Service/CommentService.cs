using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication11.Models;

namespace WebApplication11.Service
{
    public class CommentService : GenericService<Comment>, ICommentService
    {
        public CommentService(DbNewsContextEntity context) : base(context)
        {
        }
    }
}