using Gatmaitan_M1_Partial.Data;
using Gatmaitan_M1_Partial.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gatmaitan_M1_Partial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private static List<Item> items = new List<Item>
        {
            new Item { Id = 1, Name = "Laptop", Code = "ITM001", Brand = "Dell", UnitPrice = 50000, Quantity = 20 },
            new Item { Id = 2, Name = "Mouse", Code = "ITM002", Brand = "Logitech", UnitPrice = 1500, Quantity = 100 },
            new Item { Id = 3, Name = "Keyboard", Code = "ITM003", Brand = "Corsair", UnitPrice = 5000, Quantity = 50 },
            new Item { Id = 4, Name = "Monitor", Code = "ITM004", Brand = "LG", UnitPrice = 15000, Quantity = 15 },
            new Item { Id = 5, Name = "USB Cable", Code = "ITM005", Brand = "Generic", UnitPrice = 200, Quantity = 500 }
        };

        [HttpGet]
        public ActionResult<List<Item>> GetAllItems()
        {
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpGet("by-code/{code}")]
        public ActionResult<Item> GetItemByCode(string code)
        {
            var item = items.FirstOrDefault(i => i.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
            if (item == null) return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public ActionResult<Item> AddItem(Item newItem)
        {
            var exists = items.Any(i => i.Code.Equals(newItem.Code, StringComparison.OrdinalIgnoreCase));
            if (exists) return Conflict("Item with this code already exists.");
            
            newItem.Id = items.Count > 0 ? items.Max(i => i.Id) + 1 : 1;
            items.Add(newItem);
            return CreatedAtAction(nameof(GetItem), new { id = newItem.Id }, newItem);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateItem(int id, Item updatedItem)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            
            item.Name = updatedItem.Name;
            item.Code = updatedItem.Code;
            item.Brand = updatedItem.Brand;
            item.UnitPrice = updatedItem.UnitPrice;
            item.Quantity = updatedItem.Quantity;
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteItem(int id)
        {
            var item = items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            
            items.Remove(item);
            return NoContent();
        }

        // NEW: Reduce quantity when order is placed
        [HttpPost("reduce-quantity")]
        public ActionResult ReduceQuantity([FromBody] QuantityAdjustment adjustment)
        {
            var item = items.FirstOrDefault(i => i.Code.Equals(adjustment.ItemCode, StringComparison.OrdinalIgnoreCase));
            if (item == null) return NotFound("Item not found");
            
            if (item.Quantity < adjustment.Quantity)
                return BadRequest("Insufficient stock");
            
            item.Quantity -= adjustment.Quantity;
            return Ok(item);
        }

        // NEW: Restore quantity when order is cancelled
        [HttpPost("restore-quantity")]
        public ActionResult RestoreQuantity([FromBody] QuantityAdjustment adjustment)
        {
            var item = items.FirstOrDefault(i => i.Code.Equals(adjustment.ItemCode, StringComparison.OrdinalIgnoreCase));
            if (item == null) return NotFound("Item not found");
            
            item.Quantity += adjustment.Quantity;
            return Ok(item);
        }
    }

    // Helper class for quantity adjustments
    public class QuantityAdjustment
    {
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
    }
}
