// C# program to implement
// the above approach
using System;
class GFG
{

	// Function to find minimum
	// number of fountains to be
	// activated
	static int minCntFoun(int[] a, int N)
	{
		// dp[i]: Stores the position of
		// rightmost fountain that can
		// be covered by water of leftmost
		// fountain of the i-th fountain
		int[] dp = new int[N];
		for (int i = 0; i < N; i++)
		{
			dp[i] = -1;
		}

		// Stores index of leftmost
		// fountain in the range of
		// i-th fountain
		int idxLeft;

		// Stores index of rightmost
		// fountain in the range of
		// i-th fountain
		int idxRight;

		// Traverse the array
		for (int i = 0; i < N; i++)
		{
			idxLeft = Math.Max(i - a[i], 0);
			idxRight = Math.Min(i + (a[i] + 1),
								N);
			dp[idxLeft] = Math.Max(dp[idxLeft],
								idxRight);
		}

		// Stores count of fountains
		// needed to be activated
		int cntfount = 1;

		// Stores index of next
		// fountain that needed
		// to be activated
		int idxNext = 0;
		idxRight = dp[0];

		// Traverse []dp array
		for (int i = 0; i < N; i++)
		{
			idxNext = Math.Max(idxNext, dp[i]);

			// If left most fountain
			// cover all its range
			if (i == idxRight)
			{
				cntfount++;
				idxRight = idxNext;
			}
		}
		return cntfount;
	}

	// Driver Code
	public static void Main(String[] args)
	{
		int[] a = { 1, 2, 1 };
		int N = a.Length;

		Console.Write(minCntFoun(a, N));
	}
}