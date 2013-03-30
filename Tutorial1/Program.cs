using System;

namespace Tutorial1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("What is your name?");
			string name = Console.ReadLine ();
			Console.WriteLine ("How old are you?");
			int age = Int32.Parse (Console.ReadLine ());

			Console.WriteLine (String.Format ("Hello, {0} (age {1})!", name, age));

			Console.ReadKey (true);
		}
	}
}
