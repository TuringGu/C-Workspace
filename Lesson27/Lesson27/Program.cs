using System;

namespace Lesson27
{

	// Abstract method can be only in abstract class
	// Abstract class can't be instantiated directly
	public abstract class Food {

		// Abstract method
		// Note: can' t be realize in parent
		public abstract void Eat();

		// Abstract class can have common method
		public void Test() {
			Console.WriteLine ("Test");
		}
	}


	public class Apple:Food {

		// Sub class need added key words "override" when realize abstract method
		public override void Eat() {
			Console.WriteLine ("HP + 10");
		}
	}


	public class Water:Food {
		
		public override void Eat() {
			Console.WriteLine ("MP + 10");
		}
	}




	public abstract class Ball {
		public float weight;

		public void Bouncing() {
			Console.WriteLine ("Bouncing");
		}

		public abstract void Explosion();
	}

	public class Basketball:Ball {

		public override void Explosion() {
			Console.WriteLine ("Basketball explosion");
		}
	}

	public class Football:Ball {

		public override void Explosion() {
			Console.WriteLine ("Footbal explosion");
		}
	}





	class MainClass
	{
		public static void Main (string[] args)
		{
			Food f1 = new Apple ();
			Food f2 = new Water ();

			f1.Eat ();
			f2.Eat ();

			f1.Test ();

			Ball basketball = new Basketball ();
			Ball football = new Football ();


			basketball.Bouncing ();


			basketball.Explosion ();
			football.Explosion ();

			// Error
			//Food f = new Food ();
		}
	}
}
