using Stock_Control_Domain.Entities;
using Stock_Control_Services.Interfaces;
using Stock_Control_Services.Services;
using System.Web.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Stock_Control_Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ApiController
    {
        public IProductService _service;
        public ProductController(ProductService service)
        {
            _service = service;
        }
        // GET: api/<ProductController>
        [HttpGet]
        [Route("/list")]
        public IEnumerable<Product> Get()
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

        // GET api/<ProductController>/5
        [HttpGet]
        [Route("/{id}")]
        public Product? GetById(int id)
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

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] Product entity)
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
