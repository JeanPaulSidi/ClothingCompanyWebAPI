using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClothingCompanyWebAPI.Data;
using ClothingCompanyWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
using ClothingCompanyWebAPI.ModelsDTO;

namespace ClothingCompanyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ClothingCompanyWebAPIContext _context;

        public CustomersController(ClothingCompanyWebAPIContext context)
        {
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> GetCustomer()
        {
            return await _context.Customer
                .Include(Customer => Customer.Orders)
                .Select(c => new CustomerDTO 
                {
                    CustomerId = c.CustomerId,
                    CustomerFirstName = c.CustomerFirstName,
                    CustomerLastName = c.CustomerLastName,
                    CustomerEmail = c.CustomerEmail,
                    CustomerPhoneNumber = c.CustomerPhoneNumber,
                    Orders = c.Orders
                })
                .ToListAsync();
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDTO>> GetCustomer(int id)
        {
            var customer = await _context.Customer
                .Where(c => c.CustomerId == id)
                .Include(Customer => Customer.Orders)
                .Select(c => new CustomerDTO 
                {
                    CustomerId = c.CustomerId,
                    CustomerFirstName = c.CustomerFirstName,
                    CustomerLastName = c.CustomerLastName,
                    CustomerEmail = c.CustomerEmail,
                    CustomerPhoneNumber = c.CustomerPhoneNumber,
                    Orders = c.Orders
                })
                .SingleOrDefaultAsync();

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }
    }
}
