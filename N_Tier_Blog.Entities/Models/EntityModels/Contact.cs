using Blog.Core.Interfaces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Models.EntityModels
{
    public class Contact : BaseHome
    {
        public string Address { get; set; }
        [EmailAddress]
        public string EMail { get; set; }
        [Url]
        public string Location { get; set; }
    }
}
