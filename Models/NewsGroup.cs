using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication11.Models
{
    [Table("T_NewsGroups")]             // esme table
    public class NewsGroup : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]       // dige Identity(Auto Increment) nist
        public int NewsGroupId { get; set; }
        [Required]
        [MaxLength(100)]
        public string NewsGroupTitle { get; set; }
        [Required]
        [MaxLength(100)]
        public string ImageName { get; set; }

        //-------------------------------
        public virtual ICollection<News> News { get; set; }         // age virtual ro nanevisi, News Null miyare
    }
}