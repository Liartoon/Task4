using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SaleRepository
    {
        private SaleContext db;

        public SaleRepository(SaleContext context)
        {
            db = context;
        }

        public void Create(Sale item)
        {
            db.Sales.Add(item);
        }

        public void Delete(int id)
        {
            Sale sale = db.Sales.Find(id);
            if (sale != null)
                db.Sales.Remove(sale);
        }

        public Sale Get(int id)
        {
            return db.Sales.Find(id);
        }

        public IEnumerable<Sale> GetAll()
        {
            return db.Sales;
        }

        public void Update(Sale item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
