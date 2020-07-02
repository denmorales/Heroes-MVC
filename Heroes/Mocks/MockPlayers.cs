using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Heroes.Interfaces;
using Heroes.Models;

namespace Heroes.Mocks
{
    public class MockPlayers : IAllPlayers
    {
        private readonly IPlayersClub _ClubPlayers = new MockClub();
        public IEnumerable<Player> Players
        {
            
            get
            {
                return new List<Player>
                {
                    new Player
                    {
                        name = "Denis", available = true, isFavourite = true, price = 300,
                        LongDesc = "", ShortDesc = "Лучший игрок всех времен и народов, честно", img = "/img/den.jpg", Club = _ClubPlayers.AllClubs.First()
                    },
                    new Player
                    {
                        name = "Sergo", available = true, isFavourite = true, price = 1000,
                        LongDesc = "", ShortDesc = "Настоящий Костолом", img = "/img/ser.jpg", Club = _ClubPlayers.AllClubs.Last()
                    },
                    new Player
                    {
                        name = "Pavel", available = true, isFavourite = true, price = 200,
                        LongDesc = "", ShortDesc = "Легенда Тулы", img = "/img/pash.jpg", Club = _ClubPlayers.AllClubs.First()
                    },
                    new Player
                    {
                        name = "Vitaliy", available = true, isFavourite = true, price = 100,
                        LongDesc = "", ShortDesc = "Лучший бомбардир ФШФ", img = "/img/vit.jpg", Club = _ClubPlayers.AllClubs.Last()
                    },
                    new Player
                    {
                        name = "Alexandr", available = true, isFavourite = true, price = 100,
                        LongDesc = "", ShortDesc = "Меняет клубы как перчатки", img = "/img/san.jpg", Club = _ClubPlayers.AllClubs.First()
                    },
                    new Player
                    {
                        name = "Алексей", available = true, isFavourite = true, price = 100,
                        LongDesc = "", ShortDesc = "Свободный агент", img = "/img/lesh.jpg", Club = _ClubPlayers.AllClubs.First()
                    },
                    new Player
                    {
                        name = "Игорь", available = true, isFavourite = true, price = 100,
                        LongDesc = "", ShortDesc = "Забивает головой", img = "/img/igr.jpg", Club = _ClubPlayers.AllClubs.First()
                    },
                };
            }
        }

        public IEnumerable<Player> GetFavPlayers { get; set ; }

        public Player GetObjectPlayer(int playerId)
        {
            throw new NotImplementedException();
        }
    }
}
