using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.DataAccess.EfGenericRepository
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        void Insert(T entity);
        void Delete(object id);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> GetAll { get; }
        IQueryable<T> GetAllNoTracking { get; }
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includedProperties);
        IQueryable<T> GetAllIncluding(string includedProperties);
        T GetById(object id);
    }
}
