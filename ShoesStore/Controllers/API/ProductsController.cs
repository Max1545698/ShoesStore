using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoesStore.DAL.Entities;

namespace ShoesStore.Controllers.API
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        [Produces(typeof(Product))]
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody]Product product)
        {
            var response = new Product()
            {
                Id = 10,
                IsActive = true,
                Name = "Lacoste",
                Price = 500.50m
            };
            return Ok(response);
        }
    }
}