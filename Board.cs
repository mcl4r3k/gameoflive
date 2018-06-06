using System;

namespace GameOfLife
{
	public class Board
	{
		public Board(int x, int y)
		{
			this.x = x;
			this.length = length;
		}

		public int[,] FillGameboard ()
		{
			Random rnd = new Random ();	
			int[,] gamefield = new int[x, length];
			for (int i=0; i<=9; i++)
			{
				for (int z=0; z<=9; z++)
				{
					
					int rndNumber = rnd.Next(0, 2);
					gamefield [i, z] = rndNumber;
				}

			}

			return gamefield;
		}

		public void PrintGameboard(Array gamefield)
		{
			foreach(int element in gamefield)
			{
				System.Console.WriteLine (element);
			}

		}

		public void OutputBoard(int [,] outputarray)
		{


		
			string row = "";
		
			for (int y = 0; y <= 2; y++)
			{
				
				for (int x = 0; x <= 2; x++)
				{
					row += outputarray[x,y].ToString (); 

				}

				Console.WriteLine (row);
				row = "";
					

			}
		}
	

	}	

	
	}






