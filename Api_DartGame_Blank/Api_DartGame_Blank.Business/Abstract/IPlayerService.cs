using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_DartGame.Entities;

namespace Api_DartGame_Blank.Business.Abstract
{
    public interface IPlayerService
    {
        List<Players> GetAllPlayers();

        Players GetPlayerById(int id);

        Players CreatePlayer(Players player);

        Players UpdatePlayer(Players player);

        void DeletePlayer(int id);


    }
}
