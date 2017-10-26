using System;

namespace Lesson19
{

	public class array
	{
		//private string name;
		//private int[] element;

		private int length;

		public void PrintArray(int[] array)
		{
			length = array.Length;
			for (int i = 0; i < length; i++) {
				Console.Write (array[i] + "\t");
			}
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			array A = new array();

			int[] array1d = new int[5] {
				1, 3, 9, 11, 3
			};

			A.PrintArray (array1d);

		}
	}
}
