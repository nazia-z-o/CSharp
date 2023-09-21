using System;
using PersonalDataController.Model;

namespace PersonalDataController
{
	public class PersonalDataIOController
	{
		Person person=new Person();
        DOBVAlidator dOBVAlidator = new DOBVAlidator();
        PhoneValidator phoneValidator = new PhoneValidator();
        EmailValidator emailValidator = new EmailValidator();

		public bool IOController()
		{
			Console.WriteLine("Please Enter First Name: ");
			string val = TakeInput();
			if (String.IsNullOrEmpty(val))
				return false;
			person.firstName = val;


            Console.WriteLine("Please Enter Last Name: ");
			val = TakeInput();
            if (String.IsNullOrEmpty(val))
                return false;
            person.lastName = val;

            Console.WriteLine("Please Enter Address: ");
            val = TakeInput();
            if (String.IsNullOrEmpty(val))
                return false;
            person.address= val;

            Console.WriteLine("Please Enter DateOfBirth: ");
            val = TakeInput();
            if (String.IsNullOrEmpty(val))
                return false;
            //check if DOB valid or not
            //person.dob= val;
            Console.WriteLine("Please Enter Phone Number: ");
            val = TakeInput();
            if (String.IsNullOrEmpty(val))
                return false;
            //check if phone number valid or not
            //person.phone = val;
            Console.WriteLine("Please Enter email Address: ");
            val = TakeInput();
            if (String.IsNullOrEmpty(val))
                return false;
            //checkif Email valid or not
            //person.email = val;

            return true;
		}
        public void ShowErrorMsg(string msg)
        {
            Console.WriteLine("Sorry Found Error in input. Please Enter" + msg);
        }
        private string TakeInput()
		{
			string input = Console.ReadLine();
			int cnt = 3;
			while( cnt>0 && String.IsNullOrEmpty(input))
			{
				ShowErrorMsg("Valid data");
                input = Console.ReadLine();
				cnt--;
            }
			return input;
        }
	}
}

