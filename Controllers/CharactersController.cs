using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    public class CharactersController:ControllerBase
    {
        [HttpGet("api/characters")]
        public JsonResult GetCharacters()
        {
            return new JsonResult(
                new List<object>
                {
                    new { id = 1, name =  "Charmander" },
                    new { id = 2, name = "Pikachu"},
                    new { id = 3, name = "Charmeleon"}
                });
                
                
        }
    }
}
