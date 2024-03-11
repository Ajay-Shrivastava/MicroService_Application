using Microsoft.AspNetCore.Mvc;

namespace CheckoutService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController(ILogger<CheckoutController> logger) : ControllerBase
    {
        [HttpPost]
        [Route("PlaceOrder")]
        public async Task<IActionResult> PlaceOrder(object Data)
        { 
            logger.LogInformation("Method Invoked Successfully with data = " + Data.ToString());
            return Ok();
        }
    }
}
