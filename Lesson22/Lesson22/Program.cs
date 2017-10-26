using System;

namespace Lesson22
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string str;
			str = "LanOuKeji/Jinwuxing/Qinghe/Haidian/Beijing 2016";
			string[] strs = str.Split (new char[]{'/'}, 5);
			foreach (string s in strs) {
				Console.WriteLine (s);
			}
		}
	}
}
