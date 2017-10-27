using System;
using System.Collections.Generic;	// Using generic collection
using System.Collections;			// Using non-generic collection

namespace Lesson34
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// 1. declare a List object arr
			List<string> arr = new List<string> ();

			// Add element by using Add() method
			arr.Add ("Hello");
			arr.Add ("world");
			arr.Add ("Lanou");

			// Using Insert() method to insert element
			arr.Insert(1, "老王");

			arr.Remove ("world");

			arr.RemoveAt (1);

			int c = arr.Count;

			bool b = arr.Contains ("Lanou");
			Console.WriteLine (b);

			arr[0] = "你好";
			string str = arr [1];
			Console.WriteLine (str);

			arr.Clear ();

			// ArrayList don't have limit to element type
			ArrayList a = new ArrayList();
			a.Add ("Hello");
			a.Add (14);
			a.Add (15.6f);

			/* For ArrayList haven't limit to element type,
			 * system will see these elements as object type to stort themss
			*/
			string s = (string)a [0];
			Console.WriteLine (s);


		}
	}
}
