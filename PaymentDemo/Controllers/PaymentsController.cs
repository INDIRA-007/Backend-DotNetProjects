using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentDemo.Services;

namespace PaymentDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        //call the payment service
        private readonly PaymentService _service;
        public PaymentsController(PaymentService service)
        {
            _service = service;

        }

        [HttpPost]
        public IActionResult Pay(decimal amount)
        {
            var success = _service.MakePayment(amount);
            return success ? Ok("Payment processed") : BadRequest("Payment failed");

        }


    }
}
