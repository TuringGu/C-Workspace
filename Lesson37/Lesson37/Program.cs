using System;

namespace Lesson37
{
	/* Define Delegate */
	public delegate void Something(string name);



	public class Student {
		private string name;


		public void Do(Something sth) {
			// Call method A (method callback)
			sth (name);
		}

		public Student (string name) {
			this.name = name;
		}
	}




	public class Teacher {

		public void Hungry() {
			Student s = new Student ("老王");
			Something a = new Something (A);
			Something b = new Something (B);
			Something c = a + b;

			// Delegate object can use +, - to bounding or unbounding other delegates
			c = c - a;
			s.Do (c);
		}

		public void A(string name) {
			Console.WriteLine ("Hello, " + name);
		}

		public void B(string name) {
			Console.WriteLine (name + " 跑十圈");
		}
	}




	class MainClass
	{
		public static void Main (string[] args)
		{
			Teacher t = new Teacher ();
			t.Hungry ();

		}
	}
}
