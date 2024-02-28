using Api_DartGame_Blank.Business.Abstract;
using Api_DartGame_Blank.DataAccess.Abstract;
using Api_DartGame_Blank.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_DartGame.Entities;

namespace Api_DartGame_Blank.Business.Concrete
{
    public class PlayerManager : IPlayerService
    {

        private IPlayerRepository _playerRepository;

        public PlayerManager()
        {
            _playerRepository = new PlayerRepository();
        }

        public Players CreatePlayer(Players player)
        {
            return _playerRepository.CreatePlayer(player);
        }

        public void DeletePlayer(int id)
        {
            _playerRepository.DeletePlayer(id);
        }

        public List<Players> GetAllPlayers()
        {
            return _playerRepository.GetAllPlayers();
        }

        public Players GetPlayerById(int id)
        {
            if (id > 0)
            {
                return _playerRepository.GetPlayerById(id);
            }
            else
            {
                throw new Exception("Id can not be less than 1.");
            }
     
        }

        public Players UpdatePlayer(Players player)
        {
            return _playerRepository.UpdatePlayer(player);
        }
    }
}
