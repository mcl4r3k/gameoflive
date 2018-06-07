using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameOfLife
{
    public class Board
    {
         int width;
         int length;
        

        
        public Board(int x, int y)
        {
            width = x;
            length = y;
            
        }

        
        
        public int[,] FillGameboard()
        {
            Random rnd = new Random();
           
            int[,] gamefield = new int[width, length];
            for (int i = 0; i <= width-1; i++)
            {
                for (int z = 0; z <= length-1; z++)
                {

                    int rndNumber = rnd.Next(0, 2);
                    gamefield[i, z] = rndNumber;
                }

            }

            return gamefield;
        }

        public void PrintGameboard(Array gamefield)
        {
            foreach (int element in gamefield)
            {
                System.Console.WriteLine(element);
            }

        }

        public void OutputBoard(int[,] outputarray)
        {

            string row = "";

            for (int y = 0; y <= width-1; y++)
            {

                for (int x = 0; x <= length-1; x++)
                {
                    row += outputarray[x, y].ToString();

                }

                Console.WriteLine(row);
                row = "";


            }
        }


    }


}
