using System;

namespace Lesson10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Relational operator */
			// >, <, >=, <=, ==, !=
			int a = 4;
			int b = 8;
			bool r = a > b;
			Console.WriteLine (r);


			// Assignment < Relational <  Comment Arithmetic
			r = 5 == 5;	// r = true
			r = 4 != 6;	// r = true
			Console.WriteLine (r);

			/* Logical operator */
			r = true || false;	// r = true
			Console.WriteLine (r);

			// Short circuit phenomenon in logic operation
			int x = 4;
			r = (false && (x++ < 10));
			Console.WriteLine (r);
			Console.WriteLine (x);

			// Logic negation operators
			r = !false;
			Console.WriteLine (r);


			/* A little exam */
			Console.WriteLine ("Enter a1: ");
			int a1 = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Enter b1: ");
			int b1 = int.Parse(Console.ReadLine ());
			Console.WriteLine ("Enter c1: ");
			int c1 = int.Parse(Console.ReadLine ());

			bool result = (a1 > b1) && (a1 > c1);
			Console.WriteLine (result);

		}
	}
}
