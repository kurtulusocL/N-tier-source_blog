using Blog.Core.Interfaces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Models.EntityModels
{
    public class Tag : BaseHome
    {
        public string Name { get; set; }

        public int? ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
