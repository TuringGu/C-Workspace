using System;

namespace Lesson24
{
	public class Math{

		/* 1. Recursion must have end condition
		*/
		public int F(int n){
			if (n > 1) {
				// End condition
				return F (n - 1) + n;
			} else {
				return 1;
			}
		}


		public long Factorial(long n) {
			if (n > 1) {
				return Factorial (n - 1) * n;
			} else {
				return 1;
			}
		}




	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Math m = new Math ();
			Console.WriteLine (m.F(100));
			Console.WriteLine (m.Factorial(18));
		}
	}
}
