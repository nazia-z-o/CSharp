using System.Text.RegularExpressions;

namespace PersonalDataController
{
    internal class EmailValidator
    {
        private bool validEmail;
        
        public EmailValidator(string email)
        {
            checkEmail(email);
        }
        private void checkEmail(string email)
        {
            if (String.IsNullOrEmpty(email) || email == "@" || !(email.Contains('@')))
                validEmail = false;
            validEmail = true;
        }
        public bool IsValidEmail()
        {
            return validEmail;
        }
    }
}