using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ProductRepository :IRepository<Product>
    {
        private SaleContext db;

        public ProductRepository(SaleContext context)
        {
            db = context;
        }

        public void Create(Product item)
        {
            db.Products.Add(item);
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
                db.Products.Remove(product);
        }

        public Product Get(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return db.Products;
        }

        public void Update(Product item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
