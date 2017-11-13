using System;

namespace PersonRepository.Interface
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime StartDate { get; set; }
		public int Rating { get; set; }


		public override string ToString()
		{
			return "Name: " + FirstName + " " +
				   LastName + "\nDate started: " + StartDate.ToString()
				   + "\nRating: " + Rating;
		}
	}
}
