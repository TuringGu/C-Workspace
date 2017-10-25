using System;

namespace Lesson16
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[,] array2d = new int[3, 4]
			{
				{18, 13, 8, 9 },
				{24, 33, 6, 2 },
				{18, 2, 58, 19}
			};

			int max = array2d[0, 0];
			int ti = 0, tj = 0;
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					if (max < array2d[i, j])
					{
						max = array2d[i, j];
						ti = i; tj = j;
					}

				}
			}

			Console.WriteLine("The max element in array2d: [{0}, {1}] = {2}", ti, tj, max);


			Console.WriteLine("Print the transposition matrix: ");
			int[,] array2dt = new int[4, 3];
			for (int i = 0; i < 4; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					array2dt[i, j] = array2d[j, i];
					Console.Write(array2dt[i, j] + "\t");
				}
				Console.WriteLine("");
			}


			int[] intArray = { 1, 2, 3, 4, 5 };
			int sum = 1;
			foreach(int num in intArray)
			{
				sum *= num;
			}

			Console.WriteLine("sum = " + sum);
		}
	}
}
