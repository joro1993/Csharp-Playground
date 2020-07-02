using ConvertListAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace ConvertListAPI.Controllers
{
    [Route("api/product")]
    public class ProductController : Controller
    {
        [Produces("application/json")]
        [HttpGet("findall")]
        public IActionResult FindAll()
        {
            try
            {
                var products = new List<Product>()
                {
                    new Product() {Id = "P01", Name = "Product One", Price = 4},
                    new Product() {Id = "P02", Name = "Product Two", Price = 5},
                    new Product() {Id = "P03", Name = "Product Three", Price = 6}
                };
                return Ok(products);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
