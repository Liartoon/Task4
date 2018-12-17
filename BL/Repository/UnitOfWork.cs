using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UnitOfWork : IDisposable
    {
        private SaleContext db = new SaleContext();
        private ClientRepository _clientRepository;
        private ManagerRepository _managerRepository;
        private ProductRepository _productRepository;
        private SaleRepository _saleRepository;

        private bool disposed = false;

        public ClientRepository Clients
        {
            get
            {
                if (_clientRepository == null)
                    _clientRepository = new ClientRepository(db);
                return _clientRepository;
            }
        }

        public ManagerRepository Managers
        {
            get
            {
                if (_managerRepository == null)
                    _managerRepository = new ManagerRepository(db);
                return _managerRepository;
            }
        }

        public ProductRepository Products
        {
            get
            {
                if (_productRepository == null)
                    _productRepository = new ProductRepository(db);
                return _productRepository;
            }
        }

        public SaleRepository Sales
        {
            get
            {
                if (_saleRepository == null)
                    _saleRepository = new SaleRepository(db);
                return _saleRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
