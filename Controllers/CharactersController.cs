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
        
        
            
                
                
        
    }
}
