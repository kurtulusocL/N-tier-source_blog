using Blog.Core.Interfaces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Models.EntityModels
{
    public class Ad : BaseHome
    {
        public string CompanyName { get; set; }
        [Url]
        public string Website { get; set; }
        public string Title { get; set; }
        public DateTime DeletingDate { get; set; }
        public int? Hit { get; set; }
        public string Photo { get; set; }
        public Ad()
        {
            Hit = 0;
        }
    }
}
