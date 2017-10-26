using System;

namespace Lesson20
{

	public class Person
	{
		private string name;

		// Attribute
		public string Name
		{
			private get
			{
				return name;
			}

			set
			{ 	// value key word just have meaning in attribute set,
				// represent outside input values
				name = value;
			}
		}

//		public string nameGetter()
//		{
//			return name;
//		}
//
//		public void nameSetter(string newName)
//		{
//			name = newName;
//		}
//
	}


	class MainClass
	{
		public static void Main (string[] args)
		{
			Person p = new Person ();
			p.Name = "Lanou";
			
		}
	}
}
