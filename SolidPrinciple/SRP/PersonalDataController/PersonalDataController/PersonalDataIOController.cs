using System;
using PersonalDataController.Model;

namespace PersonalDataController
{
	public class PersonalDataIOController
	{
		
        DOBVAlidator dOBVAlidator ;
        PhoneValidator phoneValidator ;
        EmailValidator emailValidator;
        PersonDataValidator personDataValidator = new PersonDataValidator();

        public bool IOController()
		{
            Person person = new Person();
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
            dOBVAlidator = new DOBVAlidator(val);
            if (!dOBVAlidator.IsValidDOB())
            {
                Console.WriteLine("Your date is not valid");
                return false;
            }
            person.dateofBirth= val;
            person.setAge();

            Console.WriteLine("Please Enter Phone Number: ");
            val = TakeInput();
            if (String.IsNullOrEmpty(val))
                return false;
            //check if phone number valid or not
            phoneValidator = new PhoneValidator(val);
            if(!phoneValidator.IsValidPhone())
            {
                Console.WriteLine("Your phone number is not valid");
                return false;
            }
            person.phone = val;

            Console.WriteLine("Please Enter email Address: ");
            val = TakeInput();
            if (String.IsNullOrEmpty(val))
                return false;

            //checkif Email valid or not
            emailValidator = new EmailValidator(val);
            if(!emailValidator.IsValidEmail())
            {
                Console.WriteLine("Your email is not valid");
                return false;
            }
            person.email = val;

            personDataValidator.StorePersonData(person);
            return true;
		}
        
        private string TakeInput()
		{
			string input = Console.ReadLine();
			int cnt = 3;
			while( cnt>0 && String.IsNullOrEmpty(input))
			{
                Console.WriteLine("Sorry Found Error in input. Please Enter valid data");
                input = Console.ReadLine();
				cnt--;
            }
			return input;
        }
	}
}

