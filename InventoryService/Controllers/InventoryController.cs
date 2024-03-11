using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace InventoryService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController(ILogger<InventoryController> logger) : ControllerBase
    {
        [HttpPost]
        [Route("CheckoutProducts")]
        public async Task<IActionResult> CheckoutProducts()
        {
            var client = new DaprClientBuilder().Build();
            await client.InvokeMethodAsync("CheckoutService", "api/Checkout/PlaceOrder", data: new { name = "AjayShrivastava" });
            logger.LogInformation("Trying to invoke method of checkout service from Inventory Service");

            return Ok();
        }

    }
}
