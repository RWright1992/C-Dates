using System;
using System.Globalization;

//Know issue entering 29th February will produce error: Run-time exception (line 41): Year, Month, and Day parameters describe an un-representable DateTime.

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter your date of birth (ddmmyyyy)"); //Message to be displayed to user
		var userInput = Console.ReadLine(); //setting var for user input

		/*		Old logic for validating date entered
		int[] dateMonthArray = new int[4]; //Empty array to add ddmm to
		int counter = 0; //counter for ddmm
		foreach (char c in userInput) //logic for validating all characters entered are numbers
		{
			if (!char.IsNumber(c)) { //if any character isnt a number user will get displayed message and program will exit
				Console.WriteLine("Please enter in the format ddmmyyyy");
				return; //exiting program (possibly update to return to start)
			}
			if (counter < 4) { //used to add character to date month array
				dateMonthArray[counter] = int.Parse(c.ToString()); //adding ddmm to to array
				counter += 1; 
			}
			
		};
		
		if (dateMonthArray[2] == 1 && dateMonthArray[3] > 2){ //validation check if user enters month above 13
			Console.WriteLine("Please enter in the format ddmmyyyy");
			return; //exiting program (possibly update to return to start)
		}
		else if (dateMonthArray[2] == 0 && dateMonthArray[3] == 0 ) { //validation check if user enters 00 as month
			Console.WriteLine("Please enter in the format ddmmyyyy");
			return; //exiting program (possibly update to return to start)
		};
		*/
		
		
		DateTime today = DateTime.Today; //setting Datetime set to today
		DateTime eighteenYearsAgo = today.AddYears(-18); //setting DateTime for 18 years ago
		DateTime dateOfBirth; //setting datetime to parse user input into
		DateTime.TryParseExact(userInput, "ddMMyyyy", null,DateTimeStyles.None,out dateOfBirth); //parsing user input into dateofbirth datetime
		DateTime nextBirthday = new DateTime(today.Year, dateOfBirth.Month, dateOfBirth.Day); //creating next birthday datetime
		
		if(!dateOfBirth.Equals(DateTime.MinValue)) //validating that date entered
		{
  			if (nextBirthday < today) //logic seeing if next birthday datetime falls before todays date
			{
				nextBirthday = nextBirthday.AddYears(1); //adding year if required
			};
			
			int daysToBirthday = (nextBirthday - today).Days; //working out days to birthday
			int daysFromBirth = (today - dateOfBirth).Days; //working out days from birth
			Console.WriteLine("Days to Birthday:"+ daysToBirthday); //print out days to birthdat
			Console.WriteLine("Days from birth:"+ daysFromBirth); //print days from birth
			if (dateOfBirth > eighteenYearsAgo) //logic to work out if date of birth falls before eighteen years ago
			{
				Console.WriteLine("Under 18"); //message if user is under 18
				return; //exiting program
			}
			else
			{
				Console.WriteLine("Over 18"); //message if user is over 18
				return; //exiting program
			};
			
		}
		else  //Else statement if not entered in correct format
		{
			Console.WriteLine("Please enter in format ddmmyyyy"); //message to user
			return; //Exiting program
		};
	}
}