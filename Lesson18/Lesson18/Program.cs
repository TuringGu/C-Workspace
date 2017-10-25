using System;

namespace Lesson18
{

	// Define a struct
	struct Person
	{
		// Public type, variable name
		public string name;
		public int age;
	}

	struct Point2
	{
		public float x;
		public float y;
	}

	struct Hero
	{
		public string name;
		public float HP;
		public float MP;
	}

	struct Vector3
	{
		public float x;
		public float y;
		public float z;
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			// Declare a Person type variable
			Person p;

			p.name = "老王";
			p.age = 18;

			Console.WriteLine (p.name);
			Console.WriteLine (p.age);


			Point2 p1;
			p1.x = 2.5f;
			p1.y = 1.0f;
			Console.WriteLine ("P({0}, {1})", p1.x, p1.y);


			// Declare Vector3 type variable
			Vector3[] v = new Vector3[3];
			v [0].x = 17;
			v [0].y = 30;
			v [0].z = 26;

			v [1].x = 19;
			v [1].y = 38;
			v [1].z = 9;

			v [2].x = 14;
			v [2].y = 12;
			v [2].z = 11;

			float min;
			int[] index = new int[3] 
			{
				-1, -1, -1
			};
				
			// Sort by increment
			for (int i = 0; i < 3; i++) 	
			{
				min = float.MaxValue;	// min initialization
				for (int j = 0; j < 3; j++) 
				{
					if (min > v [j].x) 
					{
						bool flag = true;
						for (int k = 0; k < i; k++)
						{
							if (index [k] == j) 
							{
								flag = false;	// Already recorded
								break;
							}
						}

						if (flag)	// If not recorded
						{
							min = v [j].x;
							index [i] = j;
						}
					}
				}
			}


			// print
			for (int i = 0; i < 3; i++) 
			{
				Console.WriteLine ("v{0}: ({1}, {2}, {3})",
					index[i], v[index[i]].x, v[index[i]].y, v[index[i]].z);
			}


		}
	}
}
