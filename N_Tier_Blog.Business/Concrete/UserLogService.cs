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
    public class UserLogService : IUserLogService
    {
        private readonly IGenericRepository<UserLog> _userLogService;
        private readonly ApplicationDbContext _context;
        public UserLogService(IGenericRepository<UserLog> userLogService, ApplicationDbContext context)
        {
            _userLogService = userLogService;
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserLog Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserLog> GetAll()
        {
            throw new NotImplementedException();
        }

       

        public void SetActive(int id)
        {
            throw new NotImplementedException();
        }

        public void SetDeActive(int id)
        {
            throw new NotImplementedException();
        }
    }
}
