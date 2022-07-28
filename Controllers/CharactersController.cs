using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        
        private readonly SuperSmashDBContext _context; 

        public CharactersController(SuperSmashDBContext context) => _context = context; 

        [HttpGet]
        public async Task <IEnumerable<Character>> Get()
        
            => await _context.Characters.ToListAsync();

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        { 
         var CharDelete = await _context.Characters.FindAsync(id);
            if (CharDelete == null)
            {
                return NotFound();
            }

            _context.Characters.Remove(CharDelete); 
            await _context.SaveChangesAsync();  
            return NoContent();
        }

        [HttpPost("{name}")]
        public async Task<IActionResult> AddCharacter(string name)
        {
            var CharAdd = await _context.Characters.FindAsync(name);
            if (CharAdd == null)
            {
                return NotFound();
            }

            _context.Characters.Add(CharAdd);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}
