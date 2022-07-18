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
        }
}
