using System;

namespace Lesson30
{

	public class Super {

		public virtual string Name{
			get { 
				return "老王";
			}

		}

		public void A() {
			Console.WriteLine ("This A method is defined in Super");
		}

		// Virtual method
		public virtual void B() {
			Console.WriteLine ("This B method is defined in Super");
		}
	}
		
	public class Sub: Super {

		public override string Name {
			get { 
				return "老张";
			}
		}

		// In sub class to re implement the method in super class
		public new void A() {
			Console.WriteLine ("This A method is defined in Sub");
		}

		public override void B() {
			Console.WriteLine ("This B method is defined in Sub");
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Super super = new Super ();
			super.A ();
			super.B ();
			Console.WriteLine (super.Name);

			Sub sub = new Sub ();
			sub.A ();
			sub.B ();
			Console.WriteLine (sub.Name);

			Super c = new Sub ();
			c.A ();
			c.B ();
			Console.WriteLine (c.Name);
		}
	}
}
