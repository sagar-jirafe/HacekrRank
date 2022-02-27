//C# implementation of above solution

using System;

public class GFG
{
	static bool isprime(int j)
	{
		int count = 0;
		for (int i = 2; i <= j / 2; i++)
		{
			if (j % i == 0)
			{
				count = 1;
			}
		}
		if (count == 0)
		{
			return true;
		}
		else
			return false;
	}

	// find the sum of 1st N prime numbers
	static int SumOfPrime(int n)
	{
		int i = 0, j = 1;
		int sum = 0;
		while (true)
		{
			j++;
			if (isprime(j))
			{
				sum += j;
				i++;
			}
			if (i == n)
			{
				break;
			}
		}

		return sum;
	}
	// Driver code
	static public void Main()
	{
		int n = 5;
		// find the value of 1st n prime numbers
		Console.WriteLine("Sum of 1st N prime numbers are :" + SumOfPrime(n));

	}
	// This Code is contributed by ajit.
}
