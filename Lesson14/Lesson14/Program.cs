using System;

namespace Lesson14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("test1: \n");
			for (int i = 1; i <= 100; i++)
			{
				if (i % 7 != 0)
				{
					if (1 <= i && i < 10)
					{
						if (i != 7)
							Console.WriteLine(i);
					}
					else if (i < 100)
					{
						if (i / 10 != 7)
						if (i - (i / 10) * 10 != 7)
							Console.WriteLine(i);
					}
				}
			}


			Console.WriteLine("\ntest2: \n");
			int sum = 0;
			for (int i = 1; i <= 99; i++)
			{
				sum += i;
				i += 2;
			}
			Console.WriteLine("1 + 3 + 5 + ... + 99 = " + sum);



			Console.WriteLine("\ntest3: \n");
			for (int j = 1; j <= 9; j++)
			{
				for (int i = 1; i <= j; i++)
				{
					Console.Write(i + "*" + j + "=" + i * j + "\t");
				}
				Console.WriteLine("");
			}


			Console.ReadLine();
		}
	}
}
