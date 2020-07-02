using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.Models;

namespace Heroes.ViewModels
{
    public class PlayersListViewModel
    {
        public IEnumerable<Player> AllPlayers {  get; set; }
        public string currCategory { get; set; }
    }
}
