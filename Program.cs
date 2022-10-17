using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please enter your Date Of Birth"); //First Message for user
		string dateOfBirth = Console.ReadLine(); //user input for DOB
		int[] dateMonthArray = new int[4]; //Empty array to add ddmm to
		int counter = 0; //counter for ddmm
		foreach (char c in dateOfBirth) //validating all characters entered are numbers
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
		
		if (dateMonthArray[2] == 0 && dateMonthArray[3] > 2 ){ //validation check if user enters month above 13
			Console.WriteLine("Please enter in the format ddmmyyyy");
			return; //exiting program (possibly update to return to start)
		};
		

		
		
	}
}