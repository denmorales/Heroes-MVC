using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.Models;

namespace Heroes.Interfaces
{
    public interface IAllPlayers
    {
        IEnumerable<Player> Players { get;  }
        IEnumerable<Player> GetFavPlayers{ get; }
        Player GetObjectPlayer(int playerId);
    }
}
