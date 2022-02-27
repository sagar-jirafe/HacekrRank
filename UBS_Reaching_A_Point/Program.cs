// C# program to determine
// if starting from the
// starting position we
// can reach the end position
// in N moves moving about
// any direction
using System;

class GFG
{
	// function that returns mark
	// up value of directions
	static int value(char a)
	{
		if (a == 'U')
			return 0;
		if (a == 'R')
			return 1;
		if (a == 'D')
			return 2;
		if (a == 'L')
			return 3;

		return -1;
	}

	// function to print
	// the possible move
	static void printMove(char a,char b, int n)
	{
		// mod with 4 as completing
		// 4 steps means completing
		// one single round
		n = n % 4;

		// when n is 2 and
		// the difference
		// between moves is 2
		if (n == 2 && Math.Abs(value(a) - value(b)) == 2)
			Console.Write("Clockwise or Anticlockwise");

		// anticlockwise condition
		else if ((value(a) + n * 3) % 4 == value(b))
			Console.Write("Anticlockwise");

		// clockwise condition
		else if ((value(a) + n) % 4 == value(b))
			Console.WriteLine("Clockwise");
		else
			Console.WriteLine("Not Possible");
	}

	// Driver Code
	public static void Main()
	{
		char a = 'D', b = 'R';
		int n = 7;
		printMove(a, b, n);
	}
}