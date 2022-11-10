using Microsoft.AspNetCore.Mvc;
using ProductAPI.Model;
using ProductAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        private readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        
        [HttpGet]
        public IEnumerable<Product> getProductList()
        { 
           var productList = productService.GetProductList();
           return productList;
        }        

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            return productService.GetProductById(id);
        }

        [HttpPost]
        public Product AddProduct(Product product)
        {
            return productService.AddProduct(product);
        }

        [HttpPut]
        public Product UpdateProduct(Product product)
        {
            return productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public bool DeleteProduct(int id)
        {
            return productService.DeleteProduct(id);
        }
    }
}
