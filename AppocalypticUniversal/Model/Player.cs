using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppocalypticUniversal.Model
{
    class Player
    {
        private int _mind;
        private int _energy;
        private int _nature;
        private int _tactics;
        private int _identity;

        private string input;

        public Player()
        {

        }

        public int Mind { get => _mind; set => _mind = value; }
        public int Energy { get => _energy; set => _energy = value; }
        public int Nature { get => _nature; set => _nature = value; }
        public int Tactics { get => _tactics; set => _tactics = value; }
        public int Identity { get => _identity; set => _identity = value; }


    }
}
