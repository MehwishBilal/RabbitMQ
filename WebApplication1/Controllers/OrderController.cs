using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderS.Model;
using System.Text;

namespace OrderS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IPublishEndpoint _publishEndpoint;
        public OrderController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;

        }
        [HttpPost]
        public async Task<IActionResult> Createorder(Order order)
        {
            //order.Detailsend = Encoding.Default.GetBytes(JsonConvert.SerializeObject(order));
            //await _publishEndpoint.Publish<Order>(order);
           await _publishEndpoint.Publish<Order>(order);

            return Ok();
        }
    }
}
