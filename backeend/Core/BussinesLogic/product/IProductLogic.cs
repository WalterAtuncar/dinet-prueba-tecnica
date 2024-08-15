using Models.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.product
{
    public interface IProductLogic
    {
        IEnumerable<products02> GetList();
        int Insert(products02 obj);
    }
}
