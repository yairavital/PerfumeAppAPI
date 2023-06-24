using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PerfumeAppAPI.Data;
using PerfumeAppAPI.Data.Entities;

namespace PerfumeAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSalesController : ControllerBase
    {
        private readonly StoreDbContext _context;

        public ProductSalesController(StoreDbContext context)
        {
            _context = context;
        }

        // GET: api/ProductSales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductSale>>> GetProductsSale()
        {
          if (_context.ProductsSale == null)
          {
              return NotFound();
          }
            return await _context.ProductsSale.ToListAsync();
        }

        // GET: api/ProductSales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductSale>> GetProductSale(int id)
        {
          if (_context.ProductsSale == null)
          {
              return NotFound();
          }
            var productSale = await _context.ProductsSale.FindAsync(id);

            if (productSale == null)
            {
                return NotFound();
            }

            return productSale;
        }

        // PUT: api/ProductSales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductSale(int id, ProductSale productSale)
        {
            if (id != productSale.Id)
            {
                return BadRequest();
            }

            _context.Entry(productSale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductSaleExists(id))
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

        // POST: api/ProductSales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductSale>> PostProductSale(ProductSale productSale)
        {
          if (_context.ProductsSale == null)
          {
              return Problem("Entity set 'StoreDbContext.ProductsSale'  is null.");
          }
            _context.ProductsSale.Add(productSale);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductSale", new { id = productSale.Id }, productSale);
        }

        // DELETE: api/ProductSales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductSale(int id)
        {
            if (_context.ProductsSale == null)
            {
                return NotFound();
            }
            var productSale = await _context.ProductsSale.FindAsync(id);
            if (productSale == null)
            {
                return NotFound();
            }

            _context.ProductsSale.Remove(productSale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductSaleExists(int id)
        {
            return (_context.ProductsSale?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
