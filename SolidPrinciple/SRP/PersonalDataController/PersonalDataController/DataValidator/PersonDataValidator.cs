using System;
using PersonalDataController.Model;

namespace PersonalDataController
{
	public class PersonDataValidator
	{
		static int personIdcnt= 0;
		static List<Person> personList= new List<Person>();

        public bool StorePersonData(Person person)
		{

            personIdcnt++;
			person.ID = personIdcnt;
			personList.Add(person);

			Console.WriteLine("Your personal data saved successfully. your id is :" + person.ID);

			return true;
		}
	}
}

