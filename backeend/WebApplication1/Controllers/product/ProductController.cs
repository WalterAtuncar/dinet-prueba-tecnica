using BussinesLogic.product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.product;

namespace WebApplication1.Controllers.product
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductLogic _productLogic;
        public ProductController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            try
            {
                return Ok(_productLogic.GetList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Insert(products02 obj)
        {
            try
            {
                return Ok(_productLogic.Insert(obj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
