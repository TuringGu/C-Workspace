using System;

namespace Lesson11
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Sequential structure
//			int a = 4;
//			int b = a * 2 + 16;
//			Console.WriteLine (b);


//			int i = 0;
//			i = int.Parse (Console.ReadLine ());
//			if (i % 2 == 0) {
//				Console.WriteLine ("输入的是偶数");
//			} else {
//				Console.WriteLine ("输入的是奇数");	
//			}

			Console.WriteLine ("Enter the year you want: ");
			int year = int.Parse (Console.ReadLine ());
			if (year % 4 == 0 && year % 100 != 0) {
				Console.WriteLine (year + " is leap year");
			} else if (year % 400 == 0) {
				Console.WriteLine (year + " is leap year");
			} else {
				Console.WriteLine (year + " is not leap year");
			}

		}
	}
}
