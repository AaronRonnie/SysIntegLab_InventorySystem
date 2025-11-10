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
            new Item { Name = "Laptop", Code = "ITM001", Brand = "Dell", UnitPrice = 50000, Quantity = 10 },
            new Item { Name = "Phone", Code = "ITM002", Brand = "Samsung", UnitPrice = 25000, Quantity = 5 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetAllItems()
        {
            return Ok(items);
        }

        [HttpGet("{code}")]
        public ActionResult<Item> GetItem(string code)
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

            items.Add(newItem);
            return CreatedAtAction(nameof(GetItem), new { code = newItem.Code }, newItem);
        }

        [HttpPut("{code}")]
        public ActionResult UpdateItem(string code, Item updatedItem)
        {
            var item = items.FirstOrDefault(i => i.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
            if (item == null) return NotFound();

            item.Name = updatedItem.Name;
            item.Brand = updatedItem.Brand;
            item.UnitPrice = updatedItem.UnitPrice;
            item.Quantity = updatedItem.Quantity;

            return NoContent();
        }

        [HttpDelete("{code}")]
        public ActionResult DeleteItem(string code)
        {
            var item = items.FirstOrDefault(i => i.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
            if (item == null) return NotFound();

            items.Remove(item);
            return NoContent();
        }
    }
}
