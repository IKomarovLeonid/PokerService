using API.Src.View;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Src.Controllers
{
    [ApiController, Route("api/games")]
    public class GamesController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<GameViewModel>> GetAsync(ulong id)
        {
            return Ok(new GameViewModel() { Id = id});
        }

        [HttpPost]
        public async Task<ActionResult<string>> PostAsync(string game)
        {
            return Ok($"Game '{game}' has been created");
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(ulong game)
        {
            return Ok($"Game '{game}' has new card");
        }
    }
}
