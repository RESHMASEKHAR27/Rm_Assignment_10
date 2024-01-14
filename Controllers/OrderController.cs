using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rm_Assignment_10.Models;
using Rm_Assignment_10.Repository;

namespace Rm_Assignment_10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderRepository orderRepository;
        public OrderController(OrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        //AddOrder
        [HttpPost("AddOrder")]
        public IActionResult AddOrder(Order order)
        {
            return StatusCode(200, orderRepository.OrderProduct(order));
        }
        //GetOrder
        [HttpGet("GetOrders")]
        public IActionResult GetOrder()
        {
            return StatusCode(200, orderRepository.GetOrders());
        }
        //DeleteOrder
        [HttpDelete("RemoveOrder/{id}")]
        public IActionResult DeleteOrder(int id)
        {
            orderRepository.DeleteOrder(id);
            return StatusCode(200, "Order deleted...");
        }
    }
}
