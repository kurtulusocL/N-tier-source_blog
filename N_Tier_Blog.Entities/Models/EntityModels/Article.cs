using Blog.Core.Interfaces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Models.EntityModels
{
    public class Article : BaseHome
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public int? Hit { get; set; }
        public int? Like { get; set; }

        public int CategoryId { get; set; }
        public int SubcategoryId { get; set; }
        public int ArticleDetailId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual ArticleDetail ArticleDetail { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public Article()
        {
            Hit = 0;
            Like = 0;
        }
    }
}
