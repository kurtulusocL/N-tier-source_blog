using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Entities.Models.Owin.UserModel
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        {

        }

        public ApplicationRole(string roleNames, string description) : base(roleNames)
        {
            this.Description = description;
        }
        public string Description { get; set; }
    }
}
