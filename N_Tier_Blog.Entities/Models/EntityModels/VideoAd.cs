using Blog.Core.Interfaces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Models.EntityModels
{
    public class VideoAd : BaseHome
    {
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public DateTime DeletingDate { get; set; }
        [Url]
        public string VideoLink { get; set; }
        [Url]
        public string Website { get; set; }
    }
}
