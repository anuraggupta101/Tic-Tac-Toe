using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Player
    {

        public string name { get; set; }

        public char symbol;
        public Player(string name, char symbol)
        {
            this.name = name;
            this.symbol = symbol;
        }
    }
}
