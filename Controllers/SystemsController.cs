using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   
        public class SystemsController : ControllerBase
        {

            private readonly SuperSmashDBContext _context;

            public SystemsController(SuperSmashDBContext context) => _context = context;

            [HttpGet]
            public async Task<IEnumerable<VGSystem>> Get()

                => await _context.VGSystems.ToListAsync();

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVGSystem(int id)
        {
            var SystemDelete = await _context.VGSystems.FindAsync(id);
            if (SystemDelete == null)
            {
                return NotFound();
            }

            _context.VGSystems.Remove(SystemDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

