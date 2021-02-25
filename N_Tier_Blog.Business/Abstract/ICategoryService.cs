using N_Tier_Blog.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Business.Abstract
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category Find(int id);
        void Insert(Category model);
        void Delete(int id);
        void Update(Category model);
        void SetDeActive(int id);
        void SetActive(int id);
    }
}
