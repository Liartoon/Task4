using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManagerRepository : IRepository<Manager>
    {
        private SaleContext db;

        public ManagerRepository(SaleContext context)
        {
            db = context;
        }

        public void Create(Manager item)
        {
            db.Managers.Add(item);
        }

        public void Delete(int id)
        {
            Manager manager = db.Managers.Find(id);
            if (manager != null)
                db.Managers.Remove(manager);
        }

        public Manager Get(int id)
        {
            return db.Managers.Find(id);
        }

        public IEnumerable<Manager> GetAll()
        {
            return db.Managers;
        }

        public void Update(Manager item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
