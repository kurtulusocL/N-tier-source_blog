using N_Tier_Blog.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.Business.Abstract
{
    public interface IUserLogService
    {
        IEnumerable<UserLog> GetAll();
        UserLog Find(int id);       
        void Delete(int id);
       void SetDeActive(int id);
        void SetActive(int id);
    }
}
