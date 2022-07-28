using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    public class StagesController : ControllerBase
        {

            private readonly SuperSmashDBContext _context;

            public StagesController(SuperSmashDBContext context) => _context = context;

            [HttpGet]
            public async Task<IEnumerable<Stage>> Get()

                => await _context.Stages.ToListAsync();

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStage(int id)
        {
            var StageDelete = await _context.Stages.FindAsync(id);
            if (StageDelete == null)
            {
                return NotFound();
            }

            _context.Stages.Remove(StageDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
