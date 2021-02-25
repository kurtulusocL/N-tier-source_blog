using N_Tier_Blog.Core.Interfaces.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.DataAccess.DbContext
{
    public class DbContextFactory
    {
        public static IDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
