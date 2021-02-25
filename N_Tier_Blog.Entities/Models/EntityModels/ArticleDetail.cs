using Blog.Core.Interfaces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Models.EntityModels
{
    public class ArticleDetail : BaseHome
    {
        public string Detail { get; set; }
        public string SubDetail { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
