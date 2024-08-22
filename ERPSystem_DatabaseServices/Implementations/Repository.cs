using ERPSystem_DatabaseOperation;
using ERPSystem_DatabaseServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSystem_DatabaseServices.Implementationsz
{
    public class Repository<TEntity>:IRepository<TEntity> where TEntity : class
    {
        private ERPSystemTaskEntities db;
        public Repository(ERPSystemTaskEntities db)
        {
            this.db = db;
        }
        public void Create(TEntity entity)
        {

            db.Set<TEntity>().Add(entity);
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            TEntity entity = db.Set<TEntity>().Find(Id);
            db.Set<TEntity>().Remove(entity);
            db.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int Id)
        {
            return db.Set<TEntity>().Find(Id);

        }
        public void Update(TEntity entity)
        {
            db.Entry<TEntity>(entity).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
