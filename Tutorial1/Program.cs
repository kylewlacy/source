using System;

namespace Tutorial1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("What is your name?");
			string name = Console.ReadLine ();
			Console.WriteLine (name);
			Console.ReadKey (true);
		}
	}
}
