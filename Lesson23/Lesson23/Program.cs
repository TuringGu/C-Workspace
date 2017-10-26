using System;

namespace Lesson23
{
	public class Person{

		/* Using method overloads 
		 * 1. the name should be the same
		 * 2. the parameters list in the method should not be the same 
		 * (parametersnumber Or type)
		 * 
		 * Note: when in mthod overloads, it's nothing to do with return value
		*/
		
		public int Sum(int a, int b){
			return a + b;
		}

		public float Sum(float a, float b){
			return a + b;
		}


		public int Multiply(int a, int b) {
			return a * b;
		}

		public float Multiply(float a, float b) {
			return a * b;
		}

		public double Multiply(double a, double b) {
			return a * b;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Person p = new Person ();
			Console.WriteLine (p.Sum(13, 7));

			Console.WriteLine (p.Sum(3.5f, 7.1f));

			Console.WriteLine (p.Multiply(2, 5));
			Console.WriteLine (p.Multiply (3.5, 2.7));
		}
	}
}
