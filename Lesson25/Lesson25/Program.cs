using System;

namespace Lesson25
{
	public class Person
	{
		public string name;
		public int age;

		/* Constructors
		 * 1. The name must be the same with class name
		 * 2. Don't have return value
		 * 3. Can be added parameters
		 * 4. Can be overloaded
		 * 
		 * 
		 * Note: if don't have constructor, the system will add it by default
		 * If we set a constructor to be private, it means it can't creat object
		 * via this constructor 
		 * 
		 * 
		 * Destructors
		 * 1. Only can have one destructor in a class
		 * 2. Can't have return values
		 * 3. Can't add access authority modifier
		 * 4. Can't add parameters or be overloaded
		 * 5. System call it automatically, can't be manually
		*/



		public Person(string name, int age)
		{
			Console.WriteLine("Hello");

			// Initializing member variables
			this.name = name;
			this.age = 18;
		}

		~Person()
		{
			Console.WriteLine("Destructor");
		}

	}


	public class Teacher
	{
		public string name;
		public string sex;
		public string subject;


		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public string Sex
		{
			get
			{
				return sex;
			}
			set
			{
				sex = value;
			}
		}

		public string Subject
		{
			get
			{
				return subject;
			}
			set
			{
				subject = value;
			}
		}


		public Teacher(string name, string sex, string subject)
		{
			this.name = name;
			this.sex = sex;
			this.subject = subject;
		}

	}


	public class Student
	{
		public string number;
		public string name;
		public Teacher teacher;

		public Student(string number, string name, Teacher teacher)
		{
			this.number = number;
			this.name = name;
			this.teacher = teacher;
		}

	}


	class MainClass
	{
		public static void Main(string[] args)
		{
			// Whe using the key word new to creat object, it will call the constructor
			Person p = new Person("Lanou", 18);
			Console.WriteLine(p.name);
			Console.WriteLine("End");


			Teacher t = new Teacher("Lily", "female", "mathmatic");
			Student s = new Student("19999", "William", t);

			Console.WriteLine("number: {0}, name: {1}", s.number, s.name);
			Console.WriteLine("teacher: name: {0}, sex: {1}, subject: {2}",
				s.teacher.name, s.teacher.sex, s.teacher.subject);


			Console.WriteLine();
		}
	}
}
