using System;
using System.Collections;	// Using non-generic collection

namespace Lesson33
{
	

	class MainClass
	{

		public static void Log(ArrayList arr) {
			string str = "Current arrayList have " + arr.Count + " elements: (";
			for (int i = 0; i < arr.Count; i++) {
				str += arr[i];
				if(i < arr.Count - 1) {
					str += ", ";
				}
			}
			str += ")";
			Console.WriteLine (str);
		}


		public static void Main (string[] args)
		{
			// 1. Create object
			ArrayList arr = new ArrayList ();
			Log (arr);
			// 2. Using Add() method to add any type elements
			arr.Add(17);
			arr.Add (63.5f);
			arr.Add ("老王");
			Log (arr);

			// 3. Using [index] to obtain element in specified position
			//Console.WriteLine ("arr[0] = " + arr[0]);

			// Obtain current elements' number in ArrayList
			int count = arr.Count;

			// Using Insert() method to insert element into specified position
			arr.Insert(1, "老张");
			//Console.WriteLine ("arr[1] = " + arr[1]);
			Log(arr);

			// Using Remove() method to delete specified element from ArrayList
			arr.Remove("老张");
			Log(arr);

			// Using RemoveAt() method to delete element in specified position from ArrayList
			arr.RemoveAt(1);
			Log (arr);

			// Exist determinant
			bool b = arr.Contains ("老王");
			Console.WriteLine (b);

			// Clear all the ArrayList
			arr.Clear ();
			Log (arr);
		}
	}
}
