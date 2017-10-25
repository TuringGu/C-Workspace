using System;

namespace Lesson05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Declaring variable
			sbyte a = 120;
			Console.WriteLine (a);

			byte b = 5;
			Console.WriteLine (b);

			// short int
			short c = 4;
			Console.WriteLine (c);

			ushort d = 5;
			Console.WriteLine (d);

			// integer
			int e = 4;
			Console.WriteLine (e);

			uint f = 6;
			Console.WriteLine (f);

			// long integer
			long g = 6;
			ulong h = 77;
			Console.WriteLine (g);
			Console.WriteLine (h);

			/* Decimal type */
			// Single precision
			float r = 4.56f;
			Console.WriteLine (r);

			// Double precision
			double x = 4.56;
			Console.WriteLine (x);

			/* String */
			string name = "老王";
			Console.WriteLine (name);

			/* Boolean */
			bool u = true;
			u = false;
			Console.WriteLine (u);



			// Memory Occupy
			Console.WriteLine (sizeof(byte));
			Console.WriteLine (sizeof(int));
			Console.WriteLine (sizeof(long));
			Console.WriteLine (sizeof(float));
			Console.WriteLine (sizeof(double));

		}
	}
}
