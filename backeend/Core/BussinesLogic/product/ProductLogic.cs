using Models.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork;

namespace BussinesLogic.product
{
    public class ProductLogic : IProductLogic
    {
        private IUnitOfWork _unitOfWork;
        public ProductLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<products02> GetList()
        {
            return _unitOfWork.IProduct.GetList();
        }

        public int Insert(products02 obj)
        {
           return _unitOfWork.IProduct.Insert(obj);
        }
    }
}
