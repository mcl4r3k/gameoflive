using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GameOfLife
{
    public class Connways
    {

        Board gameboard = new Board(20, 20);




        
		

        public int searchneighbour(int y, int x, int [,] currentboard)
        {

            int counter = 0;

            int xmin = x - 1;
            int xmax = x + 1;
            int ymin = y - 1;
            int ymax = y + 1;

            if (x > 0 & y > 0 && currentboard[xmin, ymin] == 1) ///top left
                counter += 1;

            if (x > 0 && currentboard[xmin, y] == 1) ///mid left
                counter += 1;

            if (x > 0 & y < 2 && currentboard[xmin, ymax] == 1) ///bottom left
                counter += 1;

            if (y > 0 && currentboard[x, ymin] == 1) ///top mid
                counter += 1;

            if (y < 2 && currentboard[x, ymax] == 1) ///bottom mid
                counter += 1;

            if (x < 2 & y > 0 && currentboard[xmax, ymin] == 1) ///top right
                counter += 1;

            if (x < 2 && currentboard[xmax, y] == 1) ///middle right
                counter += 1;

            if (x < 2 & y < 2 && currentboard[xmax, ymax] == 1) ///bottom right
                counter += 1;

            return counter;
        }

        public int [,] connwaysRules(int[,] currentboard, int[,] nextgenboard)
        {
          

            for (int i = 0; i <= currentboard.GetLength(0)-1; i++)
            {
                for (int z = 0; z <= currentboard.GetLength(1)-1; z++)
                {
                    if (currentboard[i, z] == 1)
                    {

                        if (2 <= this.searchneighbour(i, z, currentboard) && this.searchneighbour(i, z, currentboard) < 4)
                            nextgenboard[i, z] = 1;
                        else
                            nextgenboard[i, z] = 0;
                    }
                    else
                    {

                        if (this.searchneighbour(i, z, currentboard) == 3)
                        {

                            nextgenboard[i, z] = 1;

                        }
                        else
                            nextgenboard[i, z] = 0;

                    }
                }
            }
       
            currentboard = nextgenboard;
            return currentboard;
        }

    }
}


