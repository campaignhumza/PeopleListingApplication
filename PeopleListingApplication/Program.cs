using System;
using PersonRepository.Interface;

namespace DemoProj
{
	class Program
	{
		static void Main(string[] args)
		{
			IPersonRepository repo = RepositoryFactory.GetPersonRepository();
			var people = repo.GetPeople();

			foreach (var person in people)
			{
				Console.WriteLine(person.ToString());
				Console.WriteLine("*********************************");


			}

			Console.ReadKey();
		}

	}
}
