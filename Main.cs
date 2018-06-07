using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace GameOfLife
{
    public class main
    {
        public static void Main()
        {


            Connways test = new Connways();
            Board gameboard = new Board(20, 20);
            int[,] currentboard = gameboard.FillGameboard();
            int[,] nextgenboard = new int[20, 20];


            for (int generation = 0; generation <= 10; generation++)
            {
                gameboard.OutputBoard(currentboard);
                currentboard = test.connwaysRules(currentboard, nextgenboard);

                gameboard.OutputBoard(currentboard);
                Thread.Sleep(1000);
                Console.Clear();
               
                

            }
        }

        
    }
}
