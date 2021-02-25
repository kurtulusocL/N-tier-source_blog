using N_Tier_Blog.DataAccess.DbContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.DataAccess.EfGenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private IDbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        protected virtual IDbSet<T> DbSet
        {
            get { return _dbSet ?? (_dbSet = _context.Set<T>()); }
        }

        public virtual IQueryable<T> GetAll
        {
            get { return DbSet; }
        }

        public virtual IQueryable<T> GetAllNoTracking
        {
            get { return DbSet.AsNoTracking(); }
        }

        public virtual void Delete(object id)
        {
            var entityToDelete = DbSet.Find(id);
            _context.Entry(entityToDelete).State = EntityState.Deleted;
            Delete(entityToDelete);
        }

        public virtual void Delete(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                if (_context.Entry(entity).State == EntityState.Detached)
                    DbSet.Attach(entity);

                DbSet.Remove(entity);
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var fail = GenerateException(dbEx);
                throw fail;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includedProperties)
        {
            var entities = DbSet.AsQueryable();
            foreach (var includedPropery in includedProperties)
            {
                entities = entities.Include(includedPropery);
            }

            return entities;
        }

        public virtual IQueryable<T> GetAllIncluding(string includedProperties)
        {
            var entities = DbSet.AsQueryable();
            var relations = includedProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var property in relations)
            {
                entities = entities.Include(property);
            }

            return entities;
        }

        public virtual T GetById(object id)
        {
            return DbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                _context.Entry(entity).State = EntityState.Added;
                DbSet.Add(entity);
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var fail = GenerateException(dbEx);
                throw fail;
            }
        }

        public virtual void Update(T entity)
        {
            try
            {
                if (entity == null)
                    throw new ArgumentNullException("entity");

                DbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (DbEntityValidationException dbEx)
            {
                var fail = GenerateException(dbEx);
                throw fail;
            }
        }

        private static Exception GenerateException(DbEntityValidationException dbEx)
        {
            var msg = string.Empty;

            foreach (var validationErrors in dbEx.EntityValidationErrors)
                foreach (var validationError in validationErrors.ValidationErrors)
                    msg += Environment.NewLine +
                           string.Format("Property: {0} Hata: {1}", validationError.PropertyName, validationError.ErrorMessage);

            var fail = new Exception(msg, dbEx);
            return fail;
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }        
    }
}
