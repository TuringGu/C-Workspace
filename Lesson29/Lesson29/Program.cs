using System;

namespace Lesson29
{

	/* Singleton
	 * When program running, to insure a class only have one object
	 * and be convinient to access object
	 * 
	*/
	public class Player {
		public string name;
		public int level;

		public int exp;
		public int maxExp;
		public int expLevelUp;

		public int hp;
		public int maxHp;
		public int HpLevelUp;

		public bool dead;


		/* Attribute */


		/* Method */

		// 1. constructor privatization
		private Player() {
			
		}

		// 2. Provide a static instance in inner class
		private static Player _instance;

		// 3. Provide an interface to obtain instance 
		public static Player GetInstance() {
			if (null == _instance) {
				_instance = new Player ();
			}
			return _instance;
		}
			

		public void Attacked(int attackNumber) {
			Player p = Player.GetInstance ();
			p.hp -= attackNumber;
			p.hp = p.hp > 0 ? p.hp : 0;
			Die ();
		}

		public void Die() {
			Player p = Player.GetInstance ();
			if (p.hp == 0)
				p.dead = true;
			else
				p.dead = false;
		}

		public void getExp(int expNumber) {
			Player p = Player.GetInstance ();
			p.exp += expNumber;
			while (p.exp >= p.maxExp) {
				p.LevelUp ();
			}
		}

		public void LevelUp() {
			Player p = Player.GetInstance ();
			p.exp -= p.maxExp;
			p.level += 1;
			p.maxExp += p.expLevelUp;
			p.maxHp += p.HpLevelUp;
			p.hp = p.maxHp;
		}


		public void StateDisplay() {
			Console.WriteLine ("");
			Player p = Player.GetInstance ();
			Console.WriteLine ("NAME: {0}", p.name);
			Console.WriteLine ("LEVEL: " + p.level);
			Console.Write("HP: {0}/{1}\tEXP: {2}/{3}",
				p.hp, p.maxHp, p.exp, p.maxExp);
			Console.WriteLine ("");
		}
	}


	public class Bag {

		public void UseHp() {
			Player p = Player.GetInstance();
			p.hp += 10;
			p.hp = p.hp > p.maxHp ? p.maxHp : p.hp;
		}
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Player p = Player.GetInstance();
			p.name = "老王";
			p.level = 1;
			p.exp = 8;
			p.maxExp = 500;
			p.expLevelUp = 100;
			p.hp = 2;
			p.maxHp = 100;
			p.HpLevelUp = 100;

			p.StateDisplay ();

			Console.WriteLine ("Using HP bag");
			Bag b = new Bag ();
			b.UseHp ();

			p.StateDisplay ();

//			Player p2 = Player.GetInstance ();
//			Console.WriteLine (p2.name);

			Console.WriteLine ("Get 3 Hurt!");
			p.Attacked (3);
			p.StateDisplay ();

			Console.WriteLine ("3000 EXP obtain!");
			p.getExp (3000);
			p.StateDisplay ();

			Console.WriteLine ("Get 1000 Hurt!");
			p.Attacked (1000);
			p.StateDisplay ();

			if(p.dead == true)
				Console.WriteLine ("Game Over");
		}
	}
}
