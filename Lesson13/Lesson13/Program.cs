using System;

namespace Lesson13
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 1;
			int sum = 0;
			while (i <= 100) {
				sum += i++;
			}
			Console.WriteLine ("1 + 2 + ... + 100 = " + sum + "\n");


			Console.WriteLine ("Print even number in [1, 100]:\n");
			i = 1;
			while (i <= 100) {
				if (i % 2 == 0) {
					Console.WriteLine (i);
				}
				i++;
			}


			Console.WriteLine ("\ntest 3: \n");
			i = 100;
			sum = 0;
			int one = 0;
			int ten = 0;
			int hundred = 0;
			int thousand = 0;

			while (i <= 10000) {
				if (100 <= i && i < 1000) {
					hundred = i / 100;
					ten = (i - hundred * 100) / 10;
					one = i - hundred * 100 - ten * 10;
					sum = hundred + ten + one;
				} else if (i < 10000) {
					thousand = i / 1000;
					hundred = (i - thousand * 1000) / 100;
					ten = (i - thousand * 1000 - hundred * 100) / 10;
					one = i - thousand * 1000 - hundred * 100 - ten * 10;
					sum = thousand + hundred + ten + one;
				}

				if (sum == 7) {
					Console.WriteLine (i);
				}

				i++;
			}


			Console.WriteLine ("\ntest 4: \n");
			sum = 0;	i = 0;
			int temp = 0;
			do {
				i++;
				temp = sum;
				sum += i;
			} while(sum <= 10000);

			Console.WriteLine ("sum: " + temp + "   N: " + --i);

		}
	}
}
