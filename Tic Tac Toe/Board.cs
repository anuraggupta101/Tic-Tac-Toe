using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    class Board
    {
        private Cell[,] cells = new Cell[3, 3];

        public void resetBoard()
        {
            //resets the board

            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(0); j++)
                {
                    cells[i, j] = new Cell(i, j);
                }
            }
        }

        public Board()
        {
            resetBoard();
        }

        public bool isSafeCell(Cell cell)
        {
            int x = cell.x;
            int y = cell.y;

            if (x < 0 || x > 2)
                return false;

            if (y < 0 || y > 2)
                return false;
            return true;
        }


        public void Display()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(0); j++)
                {
                    Console.Write(" ");
                    Console.Write(cells[i, j].c);
                }

                Console.WriteLine("\n");
            }
        }

        public void setCell(int i, int j, char symbol)
        {
            cells[i, j].setCell(symbol);
        }

        public Cell getCell(int i, int j)
        {
            return cells[i, j];
        }

    }
}
