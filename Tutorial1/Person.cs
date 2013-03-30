using System;

namespace Tutorial1
{
	public class Person
	{
		public string Name;
		public int Age;

		public Person (string name, int age)
		{
			Name = name;
			Age = age;
		}

		public string Greeting() {
			if(Age < 18) {
				return "You are too young!";
			}

			else if(Age < 21) {
				return "You are old enough, but not old enough for the office parties!";
			}

			else {
				return String.Format ("Hello, {0} (age {1})!", Name, Age);
			}
		}

		public static Person FromInput() {
			string name;
			int age = 0;

			Console.WriteLine ("What is your name?");
			name = Console.ReadLine ();

			Console.WriteLine ("How old are you?");
			age = getAge();

			return new Person(name, age);
		}

		static int getAge() {
			int age = 0;
			string ageInput = Console.ReadLine ();

			try {
				age = Int32.Parse (ageInput);
			} catch {
				Console.WriteLine (String.Format ("{0} is not a valid age!", ageInput));
				MainClass.Quit ();
			}

			return age;
		}
	}
}

