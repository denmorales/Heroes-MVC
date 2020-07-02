using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.Models;

namespace Heroes.Interfaces
{
    public interface IPlayersClub
    {
        IEnumerable<Club> AllClubs { get; }
    }
}
