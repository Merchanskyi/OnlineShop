using Microsoft.AspNetCore.Mvc;
using OnlineShop.API.Data;
using OnlineShop.Models;
using System;
using System.Threading.Tasks;

namespace OnlineShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsProvider _productsProvider;

        public ProductsController(IProductsProvider productsProvider)
        {
            _productsProvider = productsProvider;
        }

        // GET /api/products
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var products = await _productsProvider.GetAllAsync();
            return Ok(products);
        }

        // GET /api/products/id
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(Guid id)
        {
            var product = await _productsProvider.GetAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            await _productsProvider.DeleteAsync(id);
            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult> AddAsync([FromBody] Product product)
        {
            await _productsProvider.AddAsync(product);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] Product product)
        {
            if (_productsProvider.GetAsync(product.Id) == null)
            {
                return BadRequest("Product not found");
            }

            await _productsProvider.UpdateAsync(product);

            return Ok();
        }
    }
}
