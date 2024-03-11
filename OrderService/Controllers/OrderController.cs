using Dapr;
using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Repository;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController(ILogger<OrderController> logger, OrderContext context) : ControllerBase
    {
        [Topic("pubsub", "orderpublish")]
        [HttpPost]
        [Route("CartNotification")]
        public async Task<IActionResult> CartNotification([FromBody] ResponseDTO product)
        {
            var response = context.Carts.Where(x => x.ProductId == product.Data.Id).ToList();
            if (response.Count > 0)
            {
                response[0].Quantity += 1;
                await context.SaveChangesAsync();
            }
            else
            {
                var cartData = new Cart
                {
                    ProductId = product.Data.Id,
                    PurchaseType = "Active",
                    Quantity = 1
                };

                await context.Carts.AddAsync(cartData);
                await context.SaveChangesAsync();
            }
            logger.LogInformation($"subscription Recieved for product id {product.Data.Id} name - {product.Data.ProductName}");
            return Ok();
        }
    }
}
