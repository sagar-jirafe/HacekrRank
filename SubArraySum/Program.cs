﻿using System;

namespace SubArraySum
{
    class Program
    {
        int subArraySum(int[] arr, int n,
                    int sum)
        {
            int curr_sum, i, j;

            // Pick a starting point
            for (i = 0; i < n; i++)
            {
                curr_sum = arr[i];

                // try all subarrays
                // starting with 'i'
                for (j = i + 1; j <= n; j++)
                {
                    if (curr_sum == sum)
                    {
                        int p = j - 1;
                        Console.Write("Sum found between indexes " + i + " and " + p);
                        return 1;
                    }
                    if (curr_sum > sum || j == n)
                        break;
                    curr_sum = curr_sum + arr[j];
                }
            }

            Console.Write("No subarray found");
            return 0;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] arr = { 15, 2, 4, 8, 9, 5, 10, 23 };
            int n = arr.Length;
            int sum = 23;
            p.subArraySum(arr, n, sum);
        }
    }
}
