using Core.EntitiesDb;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly ShopContext _context;
        public ItemsController(ShopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetItemsAsync()
        {
            var items = await _context.Items.ToListAsync();
            return Ok(items); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItemsAsync(int id)
        {
           return await _context.Items.FindAsync(id);
           
        }
    }
}