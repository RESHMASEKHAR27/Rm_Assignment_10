using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rm_Assignment_10.Models;
using Rm_Assignment_10.Repository;

namespace Rm_Assignment_10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductRepository productRepository;
        public ProductController(ProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        //AddProduct
        [HttpPost("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                productRepository.AddProduct(product);
                return StatusCode(200, "Success!!!");
            }
            catch (Exception )
            {

                return BadRequest();
            }

        }
        //GetProductByCategory
        [HttpGet("Get Product by Category/{category}")]
        public IActionResult GetProductByCategory(string category)
        {
            try
            {
                List<Product> products = productRepository.GetProductByCategory(category);

                if (products.Count > 0)
                {
                    return StatusCode(200, products);
                }
                else
                {
                    return StatusCode(200, "No Products found");
                }

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        //GetProductByNameorID
        [HttpGet("Get Product by Name or ID")]
        public IActionResult GetProductByNameorID(string? name, int? id)
        {
            try
            {
                Product product = productRepository.GetProductByIdorName(id, name);
                if (product == null)
                {
                    return BadRequest("No item found");
                }
                return StatusCode(200, product);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        //ModifyProduct
        [HttpPut("Modify Product")]
        public IActionResult ModifyProduct(Product product)
        {
            try
            {

                return StatusCode(200, productRepository.ModifyProduct(product));
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        //DeleteProduct
        [HttpDelete("Delete Product")]
        public IActionResult DeleteProduct(int id)
        {

            try
            {
                return StatusCode(200, productRepository.DeleteProduct(id));
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
