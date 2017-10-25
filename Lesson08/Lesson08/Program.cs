using System;

namespace Lesson08
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			/* String concatenation */
			string name = "老王";
			string say = "你好";
			say = say + name;
			//say += name;
			Console.WriteLine (say);	

			/* Escape character (ESC) */
			// \n: represents line feeds or carriage returns
			string str = "\t李白\n床前明月光，\n疑似地上霜。";
			Console.WriteLine (str);

			// \": represents double quotation marks (")
			// \\: represents \
			string s = "老王说：\"我不在衣柜里! 我喜欢吃苹果\\香蕉\\梨\"";
			Console.WriteLine (s);

			string ss = "在字符串中使用 \\n 表示换行！";
			Console.WriteLine (ss);

			// @: all escape characters are invalid in a string
			string sss = @"在字符串中使用 \n 表示换行！";
			Console.WriteLine (sss);

			// When ESC is invalid, need "" to represent "
			string ssss = @"老王说：""我不在衣柜里! 我喜欢吃苹果\香蕉\梨""";
		}
	}
}
