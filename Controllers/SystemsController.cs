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
        }
}

