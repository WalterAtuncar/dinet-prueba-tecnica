using Models.product;
using Repositories.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.product
{
    public class ProductRepository : Repository<products02>, IProductRepository
    {
        public ProductRepository(string _connectionString) : base(_connectionString)
        {
        }
    }
}
