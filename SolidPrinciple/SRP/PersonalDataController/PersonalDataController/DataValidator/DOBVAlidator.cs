namespace PersonalDataController
{
    internal class DOBVAlidator
    {
        private bool validDOB;

        public DOBVAlidator(string dob)
        {
            checkDOB(dob);
        }

        private void checkDOB(string dob)
        {
            DateTime res;
            validDOB = DateTime.TryParse(dob,out res);
        }
        public bool IsValidDOB()
        {
            return validDOB;
        }
    }
}