using System;

namespace Lesson28
{

	// In static class, can only include static members or const
	public static class A {

		// Static can only be called by class, can't be called by instance

		// Static field
		public static int i;

		/* 1. Static constructor can't have access modifier
		 * 2. can be in static class or common class
		 * 3. Will be called when first time calling the static member
		*/ 
		static A() {
			
		}


		public class B {

			// Static constructor will be called before object initialization
			static B() {
				Console.WriteLine ("B static construct method");
			}
		}


		// Static method
		public static void Test() {
			
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			/* There are 5 types buffer in memory
			 * 1. Heap: manually
			 * 2. Stack: automatically by system
			 * 
			 * 3. Static (global): all time exist when running program
			 * 4. Const: store constant value
			 * 
			 * 5. Code: store code which will be used when running program
			*/

			// Call static member by using class name directly
			A.i = 10;
			Console.WriteLine (A.i);
			A.Test ();
		}
	}
}
