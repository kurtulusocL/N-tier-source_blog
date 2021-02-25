using Blog.Core.Interfaces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Models.EntityModels
{
    public class Report : BaseHome
    {
        public string NameSurname { get; set; }
        [EmailAddress]
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }

        public int? ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
