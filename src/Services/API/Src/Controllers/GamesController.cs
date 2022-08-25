using Microsoft.AspNetCore.Mvc;

namespace API.Src.Controllers
{
    [ApiController, Route("api/games")]
    public class GamesController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> Get(ulong id)
        {
            return Ok($"Game '{id}'");
        }

        [HttpPost]
        public ActionResult<string> Post(string game)
        {
            return Ok($"Game '{game}' has been created");
        }
    }
}
