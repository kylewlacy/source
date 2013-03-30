using System;

namespace Tutorial1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person newPerson = Person.FromInput();
			Console.WriteLine (newPerson.Greeting());

			Quit ();
		}

		public static void Quit() {
			Console.WriteLine ("Press any key to quit...");
			Console.ReadKey (true);
			Environment.Exit (0);
		}
	}
}
