using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Cell
    {
        public int x { get; }
        public int y { get; }
        public char c { get; set; }

        public bool empty;

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.empty = true;
        }



        public void setCell(char symbol)
        {
            this.c = symbol;
            this.empty = false;
        }
    }
}
