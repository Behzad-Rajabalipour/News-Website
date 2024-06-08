using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.Models
{
    public class Comment : BaseEntity           
    {
        [Key]
        public int commentId {  get; set; }
        [Required,MaxLength(100)]
        public string commentText { get; set; }
        public string Name { get; set; }
        [Required,MaxLength(100)]
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int NewsId { get; set; }

        //----------------------------------
        public virtual News News { get; set; }       // age virtual ro nanevisi, News Null miyare
    }
}