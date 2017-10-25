using System;

namespace Lesson06
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Adding, dividing, multiplying, subtracting */
			int a = 0;
			a = 5 + 2;	// expression


			// In C#, a is int, the value will be 2
			a = 5 / 2;

			/* The sign is also unary operator */
			// Unary operator
			a = -5;


			/* Assignment operator */
			a = 52;
			a = a + 1;

			a += 5;	// Special assignment operator

			/* Self-increment or Self-decrement operator 
			 * they are also unary operator
			*/
			a++;	a--;

			/* The difference of this location */ 
			a = 2;
			int b = a++;	// b = 2, a = 3;

			a = 2;
			b = ++a;	// a = 3, b = 3;

			Console.WriteLine (a);
			Console.WriteLine (b);


			/// Operator priority
			/// 
			/// 1: unary operator
			/// 2: *, /, % 
			/// 3: +, - 
			/// 4: assignment operator


			/// Operator associativity
			/// 
			/// When have parentheses, the content shall be first
			/// 
			/// Left associative(+, -, *, /): 
			/// left > rigth
			/// 
			/// Right associative(assignment operator):
			/// right > left

		}
	}
}
