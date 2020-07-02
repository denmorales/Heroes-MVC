using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroes.Models
{
    public class Club
    {
        public int id { set; get; }
        public string ClubName { set; get; }
        public string desc { set; get; }
        public List<Player> Player { set; get; }
    }
}
