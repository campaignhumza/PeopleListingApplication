using PersonRepository.CSV;
using PersonRepository.Interface;

namespace DemoProj
{
	class RepositoryFactory
	{

		public static IPersonRepository GetPersonRepository()
		{
			return new CSVRepository();
		}
	}
}
