using Gatmaitan_M1_Partial.Data;
using Gatmaitan_M1_Partial.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gatmaitan_M1_Partial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();

        [HttpGet]
        public ActionResult<List<Order>> GetAllOrders()
        {
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpPost]
        public ActionResult<Order> AddOrder(Order newOrder)
        {
            if (string.IsNullOrEmpty(newOrder.ItemCode) || newOrder.OrderedQuantity <= 0)
                return BadRequest("Invalid order details.");
            
            newOrder.TotalPrice = newOrder.OrderedQuantity * newOrder.UnitPrice;
            newOrder.OrderedDate = DateTime.Now;
            newOrder.Id = orders.Count > 0 ? orders.Max(o => o.Id) + 1 : 1;
            orders.Add(newOrder);
            
            return CreatedAtAction(nameof(GetOrder), new { id = newOrder.Id }, newOrder);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateOrder(int id, Order updatedOrder)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            
            order.ItemCode = updatedOrder.ItemCode;
            order.ItemName = updatedOrder.ItemName;
            order.OrderedBy = updatedOrder.OrderedBy;
            order.OrderedQuantity = updatedOrder.OrderedQuantity;
            order.UnitPrice = updatedOrder.UnitPrice;
            order.TotalPrice = updatedOrder.OrderedQuantity * updatedOrder.UnitPrice;
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            
            orders.Remove(order);
            return NoContent();
        }
    }
}
