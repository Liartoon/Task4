using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface IRepository<T> where T : class
    {
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);

        IEnumerable<T> GetAll();
    }
}
