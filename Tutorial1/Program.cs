using System;

namespace Tutorial1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int age = 0;
			string name;

			Console.WriteLine ("What is your name?");
			name = Console.ReadLine ();

			Console.WriteLine ("How old are you?");
			age = GetAge();

			if(age < 18) {
				Console.WriteLine ("You are too young!");
				Pause ();
				Environment.Exit (0);
			}

			else if(age < 21) {
				Console.WriteLine ("You are old enough, but not old enough for the office parties!");
				Pause ();
				Environment.Exit (0);
			}

			else {
				Console.WriteLine (String.Format ("Hello, {0} (age {1})!", name, age));
			}

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
