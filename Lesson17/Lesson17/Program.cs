using System;

namespace Lesson17
{
	// Define a new enumeration type
//	enum week 
//	{
//		Monday = 4,		// 4
//		Tuesday,		// 5
//		Wednesday = 8,	// 8
//		Thursday,		// 9
//		Friday,			// 10
//		Saturday,		// 11
//		Sunday,			// 12
//	}

//	enum A
//	{
//		Name,
//		Age,
//		Sunday,
//
//	}

	enum PlayerStates
	{
		Run,
		Jump,
		SlideDown,
		TurnLeft,
		TurnRight,
		none,
	}


	class MainClass
	{
		public static void Main (string[] args)
		{
			// Declare a Week type variable

			/* The enumeration type variables must be 
			 * assigned with valid values before using
			 */
//			week w = week.Saturday;
//
//			// Could define the same enum value name in different enum type
////			A a = A.Sunday;
//
//			Console.WriteLine (w + "\t" + (int)w);


			PlayerStates ps;	// Player states
			string key = Console.ReadKey ().KeyChar.ToString ();
			switch (key) 
			{
			case "W":
				// Run
				ps = PlayerStates.Run;
				break;
			case " ":
				// Junmp
				ps = PlayerStates.Jump;
				break;
			case "S":
				// Slide down
				ps = PlayerStates.SlideDown;
				break;
			case "A":
				//	Turn left
				ps = PlayerStates.TurnLeft;
				break;
			case "D":
				// Turn right
				ps = PlayerStates.TurnRight;
				break;
			default:
				ps = PlayerStates.none;
				break;
			}

			Console.WriteLine ("");
			Console.WriteLine (ps);

		}
	}
}
