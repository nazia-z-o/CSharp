using System.Text.RegularExpressions;

namespace PersonalDataController
{
    internal class PhoneValidator
    {
        private bool validPhone;
        Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");

        public PhoneValidator(string phone)
        {
            checkPhone(phone);
        }

        private void checkPhone(string phone)
        {
            
            if (r.IsMatch(phone))
                validPhone = true;
            else
                validPhone = false;
        }
        public bool IsValidPhone()
        {
            return validPhone;
        }
    }
}