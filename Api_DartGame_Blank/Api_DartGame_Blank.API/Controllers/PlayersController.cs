using Api_DartGame_Blank.Business.Abstract;
using Api_DartGame_Blank.Business.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_DartGame.Entities;

namespace Api_DartGame_Blank.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {

        private IPlayerService _playerService;

        public PlayersController()
        {
            _playerService = new PlayerManager();
        }


        [HttpGet]
        public List<Players> Get()
        {
            return _playerService.GetAllPlayers();
        }

        [HttpGet("{id}")]
        public Players Get(int id)
        {
            return _playerService.GetPlayerById(id);
        }


        [HttpPost]
        public Players Post([FromBody]Players player)
        {
            return _playerService.CreatePlayer(player);
        }


        [HttpPut]
        public Players Put([FromBody] Players player)
        {
            return _playerService.UpdatePlayer(player);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _playerService.DeletePlayer(id);
        }

    }
}
