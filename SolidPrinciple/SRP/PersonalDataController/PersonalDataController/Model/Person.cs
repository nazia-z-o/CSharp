using System;
namespace PersonalDataController.Model
{
	public class Person
	{
		public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }

        public string dateofBirth { get; set; }
		public int age { get; private set; }
		
		public string phone { get; set; }

		public string email { get; set; }

		public void SetAge(int _age)
		{
			age = _age;
		}

	}
}

