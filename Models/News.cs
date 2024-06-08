using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.Models
{
    public class News : BaseEntity
    {
        [Key]
        public int NewsId { get; set; }
        [Required, MaxLength(100)]
        public string NewsTitle { get; set; }
        public string ImageName { get; set; }
        public DateTime RegisterDate { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public int See { get; set; }
        public int Like { get; set; }
        [Required]
        public int NewsGroupId { get; set; }
        [Required]
        public int UserId { get; set; }

        //----------------------------
        public virtual User User { get; set; }                   // age virtual ro nanevisi, User Null miyare
        public virtual NewsGroup NewsGroup { get; set; }         // age virtual ro nanevisi, NewsGroup Null miyare
        public virtual ICollection<Comment> Comments { get; set; }

    }
}