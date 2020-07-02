using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.data;
using Heroes.Interfaces;
using Heroes.Models;

namespace Heroes.repos
{
    public class ClubRepository : IPlayersClub

    {
        private readonly AppDBContent appDbContent;

        public ClubRepository(AppDBContent appDbContent)
        {
            this.appDbContent = appDbContent;
        }

        public IEnumerable<Club> AllClubs => appDbContent.club;
    }
}
