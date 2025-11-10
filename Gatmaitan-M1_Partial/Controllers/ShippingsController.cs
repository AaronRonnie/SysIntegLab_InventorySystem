using Gatmaitan_M1_Partial.Data;
using Gatmaitan_M1_Partial.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gatmaitan_M1_Partial.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingsController : ControllerBase
    {
        private static List<Shipping> shippings = new List<Shipping>();

        [HttpGet]
        public ActionResult<List<Shipping>> GetAllShippings()
        {
            return Ok(shippings);
        }

        [HttpGet("{id}")]
        public ActionResult<Shipping> GetShipping(int id)
        {
            var shipping = shippings.FirstOrDefault(s => s.Id == id);
            if (shipping == null) return NotFound();
            return Ok(shipping);
        }

        [HttpPost]
        public ActionResult<Shipping> AddShipping(Shipping newShipping)
        {
            if (string.IsNullOrEmpty(newShipping.ItemCode))
                return BadRequest("Invalid shipping details.");

            newShipping.ShippedDate = DateTime.Now;
            newShipping.Status = "Pending";
            newShipping.Id = shippings.Count > 0 ? shippings.Max(s => s.Id) + 1 : 1;

            shippings.Add(newShipping);
            return CreatedAtAction(nameof(GetShipping), new { id = newShipping.Id }, newShipping);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateShipping(int id, Shipping updatedShipping)
        {
            var shipping = shippings.FirstOrDefault(s => s.Id == id);
            if (shipping == null) return NotFound();

            shipping.ShippedTo = updatedShipping.ShippedTo;
            shipping.Status = updatedShipping.Status;
            shipping.ShippedDate = updatedShipping.ShippedDate;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteShipping(int id)
        {
            var shipping = shippings.FirstOrDefault(s => s.Id == id);
            if (shipping == null) return NotFound();
            shippings.Remove(shipping);
            return NoContent();
        }
    }
}
