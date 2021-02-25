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
    public class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _categoryRepository;
        private readonly ApplicationDbContext _context;

        public CategoryService(IGenericRepository<Category> categoryRepository, ApplicationDbContext context)
        {
            _categoryRepository = categoryRepository;
            _context = context;
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public Category Find(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAllIncluding("Subcategories").ToList();
        }

        public void Insert(Category model)
        {
            _categoryRepository.Insert(model);
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
            //var a = _categoryRepository.GetAllNoTracking.Where(i => i.Id == id).FirstOrDefault();
            //a.IsConfirmed = false;
            //_context.SaveChanges();
        }

        public void Update(Category model)
        {
            _categoryRepository.Update(model);
        }
    }
}
