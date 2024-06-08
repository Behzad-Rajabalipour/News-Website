using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.Models
{
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public string MobileNumber { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }
        public string IsActive { get; set; }

        //-------------------------------
        public virtual ICollection<News> News { get; set; }     // age virtual ro nanevisi, News Null miyare
    }
}