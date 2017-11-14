using PersonRepository.Interface;
using System;
using System.Configuration;

namespace DemoProj
{
	class RepositoryFactory
	{

		public static IPersonRepository GetPersonRepository()
		{
			string typeName = ConfigurationManager.AppSettings["RepositoryType"];
			Type repoType = Type.GetType(typeName);
			object repoInstance = Activator.CreateInstance(repoType);
			IPersonRepository repo = repoInstance as IPersonRepository;
			return repo;
		}
	}
}
