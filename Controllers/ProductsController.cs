using Microsoft.AspNetCore.Mvc;
using CsharpWebApiPractice.Models;

namespace CsharpWebApiPractice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        // In-memory data store for practice
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 55000, Category = "Electronics" },
            new Product { Id = 2, Name = "Mouse", Price = 800, Category = "Electronics" },
            new Product { Id = 3, Name = "Notebook", Price = 50, Category = "Stationery" }
        };

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            return Ok(products);
        }

        // GET: api/products/1
        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound(new { message = "Product not found" });

            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            product.Id = products.Max(p => p.Id) + 1;
            products.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // PUT: api/products/1
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updatedProduct)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound(new { message = "Product not found" });

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Category = updatedProduct.Category;

            return NoContent();
        }

        // DELETE: api/products/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound(new { message = "Product not found" });

            products.Remove(product);
            return NoContent();
        }
    }
}
