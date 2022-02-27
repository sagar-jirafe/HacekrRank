// C# implementation to Find
// length of longest subString
// with at most K normal characters
using System;

public class GFG
{

	// Function to find maximum
	// length of normal subStrings
	static int maxNormalSubString(char[] P, char[] Q,
						int K, int N)
	{

		if (K == 0)
			return 0;

		// keeps count of normal characters
		int count = 0;

		// indexes of subString
		int left = 0, right = 0;

		// maintain length of longest subString
		// with at most K normal characters
		int ans = 0;

		while (right < N)
		{

			while (right < N && count <= K)
			{

				// get position of character
				int pos = P[right] - 'a';

				// check if current character is normal
				if (Q[pos] == '0')
				{

					// check if normal characters
					// count exceeds K
					if (count + 1 > K)

						break;

					else
						count++;
				}

				right++;

				// update answer with subString length
				if (count <= K)
					ans = Math.Max(ans, right - left);
			}

			while (left < right)
			{

				// get position of character
				int pos = P[left] - 'a';

				left++;

				// check if character is
				// normal then decrement count
				if (Q[pos] == '0')

					count--;

				if (count < K)
					break;
			}
		}

		return ans;
	}

	// Driver code
	public static void Main(String[] args)
	{
		// initialise the String
		String P = "giraffe", Q = "01111001111111111011111111";

		int K = 2;

		int N = P.Length;

		int r = maxNormalSubString(P.ToCharArray(), Q.ToCharArray(), K, N);

		Console.WriteLine("Result is " + r.ToString());
	}
}