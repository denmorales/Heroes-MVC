using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.data;
using Heroes.Interfaces;
using Heroes.Models;
using Microsoft.EntityFrameworkCore;

namespace Heroes.repos
{
    public class PlayerRepository : IAllPlayers
    {
        private readonly AppDBContent appDbContent;

        public PlayerRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }
        public IEnumerable<Player> Players => appDbContent.player.Include(c=>c.CategoryID);

        public IEnumerable<Player> GetFavPlayers => appDbContent.player.Where(p => p.isFavourite).Include(c => c.CategoryID);

        public Player GetObjectPlayer(int playerId) => appDbContent.player.FirstOrDefault(p => p.id == playerId);

    }
}
