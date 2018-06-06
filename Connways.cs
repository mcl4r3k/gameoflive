using System;


namespace GameOfLife
{
	public class Connways
	{




		public int[,] nextgenboard = new int [3,3] {
			{0, 0, 0} ,   /*  initializers for row indexed by 0 */
			{0, 0, 0} ,   /*  initializers for row indexed by 1 */
			{0, 0, 0}   /*  initializers for row indexed by 2 */
		};

		public int searchneighbour(int y, int x)
		{
	
			int counter = 0;

			int xmin = x - 1;
			int xmax = x + 1; 
			int ymin = y - 1;
			int ymax = y + 1;

			if (x > 0 & y > 0 && this.currentboard [xmin, ymin] == 1) ///top left
				counter+=1;

			if (x > 0 && this.currentboard[xmin, y] == 1) ///mid left
				counter+=1;

			if (x > 0 & y < 2 && currentboard[xmin, ymax] == 1) ///bottom left
						counter+=1;

			if (y > 0 && currentboard[x, ymin] == 1) ///top mid
						counter+=1;

			if (y < 2 && currentboard[x, ymax] == 1) ///bottom mid
						counter+=1;

			if (x < 2 & y > 0 && currentboard[xmax, ymin] == 1) ///top right
						counter+=1;

			if (x < 2 && currentboard[xmax, y] == 1) ///middle right
						counter+=1;

			if (x < 2 & y < 2 && currentboard[xmax, ymax] == 1) ///bottom right
						counter+=1;
					
			return counter;
		}

		public void connwaysRules(int [,] currentboard){
			

			for (int i=0; i<=2; i++)
			{
				for (int z=0; z<=2; z++)
				{
					if (currentboard [i, z] == 1) {
					
						if (2 <= this.searchneighbour (i, z) && this.searchneighbour (i, z) < 4)
							this.nextgenboard [i, z] = 1;
						else
							this.nextgenboard [i, z] = 0;
					} else {
					
						if (this.searchneighbour (i, z) == 3) {

							this.nextgenboard [i, z] = 1;

						} else
							this.nextgenboard [i, z] = 0;
					
					}
				}
			}
			currentboard = this.nextgenboard;
		}

	}
}

