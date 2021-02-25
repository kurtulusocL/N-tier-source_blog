using N_Tier_Blog.DataAccess.EfGenericRepository;
using N_Tier_Blog.Models.EntityModels;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Business.Ninject
{
    public class DIModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGenericRepository<Category>>().To<GenericRepository<Category>>();
        }
    }
}
