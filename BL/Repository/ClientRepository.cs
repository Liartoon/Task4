using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ClientRepository : IRepository<Client>
    {
        private SaleContext db;

        public ClientRepository(SaleContext context)
        {
            db = context;
        }

        public void Create(Client item)
        {
            db.Clients.Add(item);
        }

        public void Delete(int id)
        {
            Client client = db.Clients.Find(id);
            if (client != null)
                db.Clients.Remove(client);
        }

        public Client Get(int id)
        {
            return db.Clients.Find(id);
        }

        public IEnumerable<Client> GetAll()
        {
            return db.Clients;
        }

        public void Update(Client item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
