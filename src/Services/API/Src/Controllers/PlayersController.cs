using API.Src.View;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Src.Controllers
{
    [ApiController, Route("api/players")]
    public class PlayersController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<PlayerViewModel>> GetAsync(ulong id)
        {
            return Ok(new PlayerViewModel() { Id = id});
        }

        [HttpPost]
        public async Task<ActionResult<string>> PostAsync(string player)
        {
            return Ok($"Player '{player}' has been created");
        }
    }
}
