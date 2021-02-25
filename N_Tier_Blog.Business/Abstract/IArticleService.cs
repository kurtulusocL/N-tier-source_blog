using N_Tier_Blog.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Business.Abstract
{
    public interface IArticleService
    {
        IEnumerable<Article> GetAll();
        Article Find(int id);
        Article HitRead(int? id);
        void Insert(Article model);
        void Delete(int id);
        void Update(Article model);
        void SetDeActive(int id);
        void SetActive(int id);       
        void Like(int id);
    }
}
