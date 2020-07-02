using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Heroes.Interfaces;
using Heroes.Models;

namespace Heroes.Mocks
{
    public class MockClub: IPlayersClub
    {


        IEnumerable<Club> IPlayersClub.AllClubs
        {
            get
            {
                return new List<Club>
                {
                    new Club {ClubName = "Arsenal", desc = "BestClub"},
                    new Club {ClubName = "Barcelona", desc = "WorstClub"}
                };
            }
        }
    }
}
