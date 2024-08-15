using DataAccess.product;
using Repositories.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(string conneetinString)
        {
            IProduct = new ProductRepository(conneetinString);
        }

        public IProductRepository IProduct { get; }
    }
}
