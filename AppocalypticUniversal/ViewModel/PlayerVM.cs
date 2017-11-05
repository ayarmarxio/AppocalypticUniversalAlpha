using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppocalypticUniversal.Model;

namespace AppocalypticUniversal.ViewModel
{
    class PlayerVM : Questions
    {
        private Player player;

        public PlayerVM()
        {
            Player = new Player();
        }

        public Player Player { get => player; set => player = value; }
    }
}
