using System;

namespace Tutorial1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person newPerson = new Person();

			Console.WriteLine ("What is your name?");
			newPerson.Name = Console.ReadLine ();

			Console.WriteLine ("How old are you?");
			newPerson.Age = GetAge();

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
