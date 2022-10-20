using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter your date of birth (ddmmyyyy)"); //Message to be displayed to user
		var userInput = Console.ReadLine(); //setting var
		DateTime today = DateTime.Today; //setting Datetime set to today
		DateTime dateOfBirth; //setting datetime to parse user input into
		DateTime.TryParseExact(userInput, "ddMMyyyy", null,DateTimeStyles.None,out dateOfBirth); //parsing user input
		DateTime nextBirthday = new DateTime(today.Year, dateOfBirth.Month, dateOfBirth.Day); //creating next birthday datetime
		
		if(!dateOfBirth.Equals(DateTime.MinValue)) //validating that date entered
		{
  			if (nextBirthday < today) //if birthday has passed in year add a year
			{
				nextBirthday = nextBirthday.AddYears(1);
			};
			
			int daysToBirthday = (nextBirthday - today).Days; //calculating day to next birthday
			int daysFromBirth = (today - dateOfBirth).Days; //calculating days from birth
			Console.WriteLine("Days to Birthday:"+ daysToBirthday);
			Console.WriteLine("Days from birth:"+ daysFromBirth); 
		}
	}
}