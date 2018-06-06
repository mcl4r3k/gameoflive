using System;
using System.Threading;

namespace GameOfLife
{
	public class main
	{
		public static void Main()
		{
			Connways test = new Connways ();
			Board gameboard = new Board ();
			int [,] starboard = gameboard.FillGameboard;


			for (int y = 0; y <= 10; y++) {

				test.connwaysRules (starboard);
				gameboard.OutputBoard (starboard);
				Thread.Sleep (200);
				Console.Clear ();



			}
		}
	}
}

