using System;
namespace PersonalDataController
{
	public class StandardMessege
	{
		public static void StartUpMessege(string msg)
		{
			Console.WriteLine(msg);
		}
		
		public static void EndMessege(string msg)
		{
			Console.WriteLine(msg);
			Console.WriteLine("Thank You!");
			Console.WriteLine("Press enter to close...");
			Console.ReadLine();
		}
	}
}

