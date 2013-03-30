using System;

namespace Tutorial1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string name;
			int age = 0;

			Console.WriteLine ("What is your name?");
			name = Console.ReadLine ();

			Console.WriteLine ("How old are you?");
			age = GetAge();

			Person newPerson = new Person(name, age);
			Console.WriteLine (newPerson.Greeting());

			Pause ();
		}

		public static int GetAge() {
			int age = 0;
			string ageInput = Console.ReadLine ();

			try {
				age = Int32.Parse (ageInput);
			} catch {
				Console.WriteLine (String.Format ("{0} is not a valid age!", ageInput));
				Pause ();
				Environment.Exit (0);
			}

			return age;
		}

		public static void Pause() {
			Console.WriteLine ("Press any key to quit...");
			Console.ReadKey (true);
		}
	}
}
