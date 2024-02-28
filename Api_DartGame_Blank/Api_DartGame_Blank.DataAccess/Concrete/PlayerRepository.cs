using Api_DartGame_Blank.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_DartGame.Entities;

namespace Api_DartGame_Blank.DataAccess.Concrete
{
    public class PlayerRepository : IPlayerRepository
    {
        public Players CreatePlayer(Players player)
        {
            using (var playerDbContext = new PlayersDbContext())
            {
                playerDbContext.Playerss.Add(player);
                playerDbContext.SaveChanges();
                return player;
            }
        }

        public void DeletePlayer(int id)
        {
            using (var playerDbContext = new PlayersDbContext())
            {
                var deletedPlayer = GetPlayerById(id);
                playerDbContext.Playerss.Remove(deletedPlayer);
                playerDbContext.SaveChanges();
            }
        }

        public List<Players> GetAllPlayers()
        {
            using(var playerDbContext=new PlayersDbContext())
            {
                return playerDbContext.Playerss.ToList();
            }
        }

        public Players GetPlayerById(int id)
        {
            using (var playerDbContext = new PlayersDbContext())
            {
                return playerDbContext.Playerss.Find(id);
            }
        }

        public Players UpdatePlayer(Players player)
        {
            using (var playerDbContext = new PlayersDbContext())
            {
                playerDbContext.Playerss.Update(player);
                playerDbContext.SaveChanges();
                return player;
            }
        }
    }
}
