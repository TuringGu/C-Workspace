using System;

namespace Lesson15
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// using "new", dynamic assignment
			float[] f = new float[3] { 1.6f, 2.7f, 12.9f };

			// static assignment
			string[] s = { "老王", "老张", "未知的角色名", "油腻的师姐" };
			Console.WriteLine(s[2] + s[3]);


			int[] intArray = { 2, 3, 5, 7, 11, 13, 17 };
			int sum = 0;
			int max = 0, min = 0;
			max = min = intArray[intArray.Length - 1];

			for (int i = intArray.Length - 1;  i >= 0 ;  i--)
			{
				sum += intArray[i];

				if(max < intArray[i])
				{
					max = intArray[i];
				}

				if(min > intArray[i])
				{
					min = intArray[i];
				}

				Console.Write(intArray[i] + "\t");
			}
			Console.WriteLine("");
			Console.WriteLine("sum = " + sum + "\tmax = " + max + "\tmin = " + min);
			Console.WriteLine("");
		}
	}
}
