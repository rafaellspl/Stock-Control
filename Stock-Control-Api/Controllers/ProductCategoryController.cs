using Stock_Control_Domain.Entities;
using Stock_Control_Services.Interfaces;
using Stock_Control_Services.Services;
using System.Web.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Stock_Control_Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductCategoryController : ApiController
    {
        public IProductCategoryService _service;

        public ProductCategoryController(ProductCategoryService service)
        {
            _service = service;
        }
        // GET: api/<ProductCategoryController>
        [HttpGet]
        public IEnumerable<ProductCategory> Get()
        {
            try
            {
                return _service.Get();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        // GET api/<ProductCategoryController>/id
        [HttpGet]
        [Route("{id}")]
        public ProductCategory? Get(int id)
        {
            try
            {
                return _service.GetById(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST api/<ProductCategoryController>
        [HttpPost]
        public void Post([FromBody] ProductCategory entity)
        {
            try
            {
                _service.Add(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
