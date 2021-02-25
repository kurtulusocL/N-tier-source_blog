using Blog.Core.Interfaces.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Models.EntityModels
{
    public class SendMessage : BaseHome
    {
        [EmailAddress]
        public string SenderEMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
