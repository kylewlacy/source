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

			string ageInput = Console.ReadLine ();
			try {
				age = Int32.Parse (ageInput);
			} catch {
				Console.WriteLine (String.Format ("{0} is not a valid age!", ageInput));
				Console.ReadKey (true);
				Environment.Exit (0);
			}

			Console.WriteLine (String.Format ("Hello, {0} (age {1})!", name, age));

			Console.ReadKey (true);
		}
	}
}
