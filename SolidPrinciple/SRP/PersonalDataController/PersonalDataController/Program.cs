
using PersonalDataController;

StandardMessege.StartUpMessege("Welcome to personal data registration page!\n\n");
PersonalDataIOController iOController = new PersonalDataIOController();
bool haveMoreUser = true;
while(haveMoreUser)
{
    StandardMessege.StartUpMessege("Please Enter your data.\n\n");
    var res = iOController.IOController();
    if (res)
    {
        StandardMessege.EndMessege("Done your registration! ");
    }
    else
    {
        StandardMessege.EndMessege("Sorry registration failed!");
    }
    Console.WriteLine("Have more User?(y/n)...");
    string input=Console.ReadLine();
    if (input == "y" || input == "Y") continue;
    else
        haveMoreUser = false;
}
StandardMessege.EndMessege("Completing Registration process!");
StandardMessege.closeMessege();


