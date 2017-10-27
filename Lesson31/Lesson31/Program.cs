using System;

namespace Lesson31
{

	static class Constants //推荐定义常量方式  
	{  
		public const float Pi = 3.14159f;   
	}  


	public class A {
	}

	// Food interface
	public interface Food {

		// Define attributes in interface, it also can't be implemented
		float Price{get;}

		/* Define method in interface 
		 * 1. Can't add access modifier, cause all are public by default
		 * 2. The method can't be implemented
		*/
		void Eat();

	}



	/* 3. Whenever a class implemented interface, 
	 * it must implementing all the members that defined in this interface
	 */

	// Apple class
	// Apple inherited from A , and implemented the Food interface
	public class Apple : A, Food {

		public float Price {
			get { 
				return 1.4f;
			}
		}


		public void Eat ()
		{
			// Implemented the Eat method in Food interface
			Console.WriteLine ("After ate an apple, HP + 10");
		}
	}


	public class Banana:Food {

		public void Eat ()
		{
			Console.WriteLine ("After ate a banana, HP - 10");
		}

		public float Price {
			get {
				return 5.6f;
			}
		}
	}



	// Practice
	public interface Area {
		
		float getArea();
	}

	public interface IVolume {

		float getIVolume();
	}

	public class Ball : Area, IVolume{
		public float radius;


		public float getArea ()
		{
			return 4 * Constants.Pi * this.radius * this.radius;
		}

		public float getIVolume ()
		{
			return 4 * Constants.Pi * this.radius * this.radius * this.radius / 3;
		}

	}

	public class Cube : Area, IVolume{
		public float edgeLength; 


		public float getArea ()
		{
			return 6 * this.edgeLength * this.edgeLength;
		}

		public float getIVolume ()
		{
			return this.edgeLength * this.edgeLength * this.edgeLength;
		}

	}



	class MainClass
	{
		public static void Main (string[] args)
		{
			Apple a = new Apple ();
			a.Eat ();
			Console.WriteLine (a.Price);

			// Polymorphism - using interface to implement polymorphism
			Food b = new Apple ();
			b.Eat ();
			Console.WriteLine (b.Price);

			Banana banana = new Banana ();
			banana.Eat ();


			/* 4. Can't be directly instantiation
			*/


			// Practice
			Ball ball = new Ball();
			ball.radius = 3.6f;
			Console.WriteLine ("ball: r: {0}, S: {1}, V: {2}", 
				ball.radius, ball.getArea(), ball.getIVolume());

			Cube cube = new Cube ();
			cube.edgeLength = 7.3f;
			Console.WriteLine ("cube: l: {0}, S: {1}, V: {2}",
				cube.edgeLength, cube.getArea(), cube.getIVolume());


		}
	}
}
