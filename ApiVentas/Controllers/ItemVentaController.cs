using ApiVentas.Data;
using ApiVentas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiVentas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ItemVentaController : ControllerBase
    {
        private readonly dbContext _context;

        public ItemVentaController(dbContext context)
        {
            _context = context;
        }
        // GET: api/ItemVenta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ItemVenta>>> GetItemVentas()
        {
            return await _context.ItemVentas.ToListAsync();
        }
        // GET: api/ItemVenta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ItemVenta>> GetItemVenta(int id)
        {
            var itemVenta = await _context.ItemVentas.FindAsync(id);

            if (itemVenta == null)
            {
                return NotFound();
            }

            return itemVenta;
        }
        // POST: api/ItemVenta
        [HttpPost]
        public async Task<ActionResult<ItemVenta>> PostItemVenta(ItemVenta itemVenta)
        {
            _context.ItemVentas.Add(itemVenta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetItemVenta", new { id = itemVenta.Id }, itemVenta);
        }

        // PUT: api/ItemVenta/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItemVenta(int id, ItemVenta itemVenta)
        {
            if (id != itemVenta.Id)
            {
                return BadRequest();
            }

            _context.Entry(itemVenta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemVentaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/ItemVenta/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ItemVenta>> DeleteItemVenta(int id)

        {
            var itemVenta = await _context.ItemVentas.FindAsync(id);
            if (itemVenta == null)
            {
                return NotFound();
            }

            _context.ItemVentas.Remove(itemVenta);
            await _context.SaveChangesAsync();

            return itemVenta;
        }

        private bool ItemVentaExists(int id)
        {
            return _context.ItemVentas.Any(e => e.Id == id);
        }
    }




}

