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
	}
}

