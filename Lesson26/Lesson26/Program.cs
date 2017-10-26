using System;

namespace Lesson26
{

	/* C# only support single inheritance
	 * a sub class just have one parent
	*/

	public class Person {
		public string name;
		public string sex;
		public int age;

		public void Eat() {
			Console.WriteLine ("Eat");
		}

		public void Move() {
			Console.WriteLine ("Move");
		}

		public void Sleep() {
			Console.WriteLine ("Sleep");
		}
	}


	public class Teacher:Person {
		public string subject;

		public void Teaching() {
			Console.WriteLine ("Teaching");
		}
	}


	public class Student:Person {
		public string subject;

		public void Learning() {
			Console.WriteLine ("Learning");
		}
	}


	public class President:Person {
		public string ablility;

		public void Managing() {
			Console.WriteLine ("Managing");
		}
	}


	class MainClass
	{
		public static void Main (string[] args)
		{
			
		}
	}
}
