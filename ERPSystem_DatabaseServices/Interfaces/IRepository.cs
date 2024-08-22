using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseServices.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity enntity);
        void Update(TEntity enntity);
        void Delete(int ID);
        List<TEntity> GetAll();
        TEntity GetById(int ID);
    }
}
