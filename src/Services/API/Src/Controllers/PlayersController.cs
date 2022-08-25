using Microsoft.AspNetCore.Mvc;

namespace API.Src.Controllers
{
    [ApiController, Route("api/players")]
    public class PlayersController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<string> Get(ulong id)
        {
            return Ok($"Player '{id}'");
        }

        [HttpPost]
        public ActionResult<string> Post(string player)
        {
            return Ok($"Player '{player}' has been created");
        }
    }
}
