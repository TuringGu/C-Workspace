using System;

namespace Lesson21
{
	public class MyClass
	{

		// When define the method, a & b are formal parameters
		public int Sum(int a, int b)
		{
			return a + b;
		}

		// Using ref key word to define reference type parameters
		public void Swap(ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}

		public void A(int[] arr)
		{
			arr[0] = 12;
		}

		public void SwapSort(ref int a, ref int b, ref int c)
		{
			if (a > b)
				Swap(ref a, ref b);
			if (a > c)
				Swap(ref a, ref c);
			if (b > c)
				Swap(ref b, ref c);
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			MyClass c = new MyClass();

			// When call the method, a & b are actual parameters
			Console.WriteLine(c.Sum(5, 12));

			int i = 5;
			int j = 12;
			c.Swap(ref i, ref j);

			Console.WriteLine("i = " + i);
			Console.WriteLine("j = " + j);


			int[] a = new int[] { 1 };
			c.A(a);
			Console.WriteLine(a[0]);


			int x = 7, y = 23, z = 9;
			Console.WriteLine("Sort three integer and swap the values:");
			Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
			c.SwapSort(ref x, ref y, ref z);
			Console.WriteLine("Results: x = {0}, y = {1}, z = {2}", x, y, z);

		}
	}
}
