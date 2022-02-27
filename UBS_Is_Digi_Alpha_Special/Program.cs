// C# program to find type of
// input character
using System;

class GFG
{

	// Function to check type
	// of input character
	static void charCheck(char input_char)
	{
		// Checking for Alphabet
		if ((input_char >= 65 && input_char <= 90)
			|| (input_char >= 97 && input_char <= 122))
			Console.WriteLine(" Alphabet ");

		// Checking for Digits
		else if (input_char >= 48 && input_char <= 57)
			Console.WriteLine(" Digit ");

		// Otherwise Special Character
		else
			Console.WriteLine("Special Character");
	}

	// Driver Code
	public static void Main()
	{
		char input_char = '$';
		charCheck(input_char);
	}
}

// This code is contributed by vt_m.
