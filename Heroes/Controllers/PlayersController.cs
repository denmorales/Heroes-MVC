using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.Interfaces;

using Heroes.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Heroes.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IAllPlayers _allPlayers;
        private readonly IPlayersClub _allClub;

        public PlayersController(IAllPlayers iallplayers, IPlayersClub iclub)
        {
            _allPlayers = iallplayers;
            _allClub = iclub;

        }

        public ViewResult List()
        {
            PlayersListViewModel obj = new PlayersListViewModel();
            obj.AllPlayers = _allPlayers.Players;
            obj.currCategory = "Клубы";
            return View(obj);
        }
    }
}
