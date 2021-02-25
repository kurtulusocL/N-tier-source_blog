using N_Tier_Blog.Business.Abstract;
using N_Tier_Blog.DataAccess.DbContext;
using N_Tier_Blog.DataAccess.EfGenericRepository;
using N_Tier_Blog.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Business.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IGenericRepository<Article> _articleService;
        private readonly ApplicationDbContext _context;
        public ArticleService(IGenericRepository<Article> articleService, ApplicationDbContext context)
        {
            _articleService = articleService;
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Article Find(int id)
        {
            return _articleService.GetById(id);
        }

        public IEnumerable<Article> GetAll()
        {
           return _articleService.GetAllIncluding("ArticleDetail,Category,Subcategory,Comments,Pictures,Reports,Tags").ToList();
        }

        public Article HitRead(int? id)
        {
            var hit = _context.Set<Article>().Where(i => i.Id == id).SingleOrDefault();
            hit.Hit++;
            _context.SaveChanges();
            return hit;
        }

        public void Insert(Article model)
        {
            throw new NotImplementedException();
        }

        public void Like(int id)
        {
            var like = _context.Set<Article>().Where(i => i.Id == id).FirstOrDefault();
            like.Like++;
            _context.SaveChanges();
        }

        public void SetActive(int id)
        {
            var active = _context.Set<Category>().Where(i => i.Id == id).FirstOrDefault();
            active.IsConfirmed = true;
            _context.SaveChanges();
        }

        public void SetDeActive(int id)
        {
            var deActive = _context.Set<Category>().Where(i => i.Id == id).FirstOrDefault();
            deActive.IsConfirmed = false;
            _context.SaveChanges();
        }

        public void Update(Article model)
        {
            throw new NotImplementedException();
        }
    }
}
