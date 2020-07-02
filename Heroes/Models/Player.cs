using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroes.Models
{
    public class Player
    {
        public int id { set; get; }
        public string name { set; get; }
        public string LongDesc { set; get; }
        public string ShortDesc { set; get; }
        public string img {set; get; }
        public short price { set; get; }
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int CategoryID { set; get; }
        public virtual  Club Club { set; get; }
    }
}
