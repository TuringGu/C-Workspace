using System;
using System.Collections.Generic;

namespace Lesson36
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Stack<string> s = new Stack<string> ();
			int count = s.Count;
			s.Clear ();
			bool b = s.Contains ("老王");

			s.Push ("老王");
			s.Push ("老张");
			s.Push ("小明");

			string s1 = s.Pop ();
			Console.WriteLine (s1);


			Queue<string> q = new Queue<string> ();
			q.Clear ();
			int countq = q.Count;
			bool bq = q.Contains ("老王");

			q.Enqueue ("老王");
			q.Enqueue ("老张");
			q.Enqueue ("小明");

			string s1q = q.Dequeue();
			Console.WriteLine (s1q);
		}
	}
}
