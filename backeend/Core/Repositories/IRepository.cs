using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetList();
        int Insert(T entity);
    }
}
