using Dapr.Client;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using ProductService.Repository;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(ILogger<ProductController> logger, ProductContext context) : ControllerBase
    {

        [HttpPost]
        [Route("SelectProduct")]
        public async Task<IActionResult> SelectProduct(int productId) 
        {
            /* var response = await context.FindAsync<Product>(productId);
             if (response != null )
             {*/
            //int id = 10;

            var response = new Product
            {
                Id = productId,
                Price = 15236,
                ProductDescription = "description",
                ProductName = "TestProduct"
            };
                var client = new DaprClientBuilder().Build();
                await client.PublishEventAsync("pubsub", "orderpublish", response);
                logger.LogInformation("Published an Event Through Product Service");
                return Ok("Published Successfully");
           // }

            return BadRequest();
        }
    }
} 