using System;
using PersonalDataController.Model;

namespace PersonalDataController
{
	public static class PersonDataValidator
	{
		static int IDCnt=0;
		static List<Person> personlistwithId= new List<Person>();

		public static bool setVAlidPerson(Person person)
		{
			int _age = CalculateAge(person.dateofBirth);
			person.SetAge(_age);
			IDCnt++;
			person.ID = IDCnt;
			personlistwithId.Add(person);
			return true;
		}
		private static int CalculateAge(string DOB)
		{
			return 0;
		}
		
	}
}

