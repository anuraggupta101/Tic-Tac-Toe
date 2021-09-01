using System;

namespace Tic_Tac_Toe
{
    class Program
    {

        public static bool checkWinner(Int32 i, Int32 j, Board b)
        {
            //check row
            if (b.getCell(i, 0).empty == false && b.getCell(i, 1).empty == false && b.getCell(i, 2).empty == false)
            {
                if (b.getCell(i, 0).c == b.getCell(i, 1).c && b.getCell(i, 1).c == b.getCell(i, 2).c)
                    return true;
            }

            //check col
            if (b.getCell(0, j).empty == false && b.getCell(1, j).empty == false && b.getCell(2, j).empty == false)
                if (b.getCell(0, j).c == b.getCell(1, j).c && b.getCell(1, j).c == b.getCell(2, j).c)
                    return true;

            //check left diagonal
            if (b.getCell(0, 0).empty == false && b.getCell(1, 1).empty == false && b.getCell(2, 2).empty == false)
            {
                if (b.getCell(0, 0).c == b.getCell(1, 1).c && b.getCell(1, 1).c == b.getCell(2, 2).c)
                    return true;
            }

            //check right diagonal
            if (b.getCell(0, 2).empty == false && b.getCell(1, 1).empty == false && b.getCell(2, 0).empty == false)
            {
                if (b.getCell(0, 2).c == b.getCell(1, 1).c && b.getCell(1, 1).c == b.getCell(2, 0).c)
                    return true;
            }

            return false;
        }





        static void Main(string[] args)
        {
            Player p1 = new Player("Anurag", 'X');
            Player p2 = new Player("Sunil", 'O');

            Console.WriteLine("P1:" + p1.symbol);
            Console.WriteLine("P2:" + p2.symbol);


            Board b = new Board();
            string coordinates;
            string[] values;


            for (int i = 0; i < 9; i++)
            {
                Console.Write("\n P1:");
                coordinates = Console.ReadLine();
                values = coordinates.Split(',');
                b.setCell(Int32.Parse(values[0]), Int32.Parse(values[1]), p1.symbol);
                b.Display();
                if (Program.checkWinner(Int32.Parse(values[0]), Int32.Parse(values[0]), b))
                {
                    Console.WriteLine("Winner found!!");
                    System.Environment.Exit(1);
                }

                if (i == 8)
                    break;

                Console.WriteLine("P2:");
                coordinates = Console.ReadLine();
                values = coordinates.Split(',');
                b.setCell(Int32.Parse(values[0]), Int32.Parse(values[1]), p2.symbol);
                b.Display();
                if (Program.checkWinner(Int32.Parse(values[0]), Int32.Parse(values[0]), b))
                {
                    Console.WriteLine("Winner found");
                    System.Environment.Exit(1);
                }
            }

            Console.WriteLine("Its a DRAW !!");


        }
    }
}
