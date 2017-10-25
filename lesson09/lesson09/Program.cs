using System;

namespace lesson09
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* Console output */
			Console.WriteLine ("Hello");
			Console.Write ("World!");
			Console.Write ("老王");

			/* Console input */
			//string str = Console.ReadLine ();
			//Console.WriteLine("你刚才输入了：" + str);
			Console.WriteLine ("请输入你的年龄：");
			string agestr = Console.ReadLine ();
			int age = int.Parse (agestr);
			//Console.WriteLine ("你哥哥年龄要大于等于" + age + "岁");

			/* Formatted output */
			// {} represent placeholder
			// index can be used repeatedly
			Console.WriteLine("你哥哥年龄要大于等于{0}岁，身高超过{1}厘米，他的口头禅是{2}", age, 178, "kakaka");

		}
	}
}
