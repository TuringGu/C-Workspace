using System;

namespace Lesson07
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Automatic type conversion */
			//Only low precision to high precision type conversion
			int a = 3;
			float b = 4.6f;
			b = a;
			Console.WriteLine (b);

			// Precision: byte < short < int < long
			short c = 5;
			a = c;
			Console.WriteLine (c);


			/* Cast (forced type conversion)
			 * 1. will loss precision
			 * 2. should be explicitly represented
			 */
			// 1. Using type to convert, direct rounding decimal
			int i = 5;
			float j = 15.6f;
			i = (int)j;
			Console.WriteLine (i);

			short d = 4;
			d = (short)i;
			Console.WriteLine (d);

			// 2. Using conversion method provided by the system
			int x = 6;
			float y = 9.7f;
			x = Convert.ToInt32 (y);
			Console.WriteLine (x);

			int r = 4;
			float t = Convert.ToSingle (r);
			double t1 = Convert.ToDouble (r);

			// 3. Using conversion of analytic methods 
			string str = "123";
			int v = int.Parse (str);
			Console.WriteLine (str);

			string s = "5.6";
			float ss = float.Parse (s);
			Console.WriteLine (ss);
		}
	}
}
