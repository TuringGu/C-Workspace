using System;
using System.Collections.Generic;

namespace Lesson35
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			// Create a dictionary object, key type is string, Value type is int
			Dictionary<string, int> dic = new Dictionary<string, int> ();

			dic.Add ("laowang", 13);
			dic.Add ("laozhang", 18);

			dic.Remove ("laowang");

			dic.Clear ();

			int count = dic.Count;

			// 
			bool b = dic.ContainsKey ("xiaoming");

			bool c = dic.ContainsValue (13);

			// If current directory have "xiaoming" Key, try to get respect Value s
			int s;
			bool bb = dic.TryGetValue ("xiaoming", s);

			// Obtian Value from Key
			int age = dic["laowang"];
			Console.WriteLine (age);
		}
	}
}
