using System;

namespace Lesson37
{
	/* Define Delegate */
	public delegate void Something(string name);



	public class Student {
		private string name;

		// Event is the attribute of delegate
		public event Something something;

		public void Do() {
			something (name);
		}

		public Student (string name) {
			this.name = name;
		}
	}




	public class Teacher {

		public void Hungry() {
			Student s = new Student ("老王");

			/* After using event, can't assigning value to delegate,
			 * must use +=, -= to bound or unbound
			*/
			s.something += new Something (A);

			/* After using event, can't call delegate outside Student */
			// Error
			//s.something ("老张");
			s.Do();
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

