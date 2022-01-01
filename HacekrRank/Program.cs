using System;
using System.Collections.Generic;

namespace HacekrRank
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 3, 1, 2, 1 };

            int outputArrayLength = countDistinct(arr, arr.Length);

            int[,] a1 = new int[outputArrayLength, 2];

            var ct = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                var flag = 0;
                for (var j = 0; j < ct; j++)
                {
                    if (a1[j, 0] == arr[i])
                    {
                        a1[j, 1] = a1[j, 1] + 1;
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    a1[ct, 0] = arr[i];
                    a1[ct++, 1] = 1;
                }
            }

            arraySort(a1);

            for (var i = 0; i < ct; i++)
            {
                Console.WriteLine("[" + a1[i, 0].ToString() + "," + a1[i, 1].ToString() + "]");
            }

            Console.ReadKey();
        }

        private static int[,] arraySort(int[,] a1)
        {
            var n = a1.Length;
            for (var i = 0; i < n - 1; i++)
            {
                for (var j = 0; j < n - i - 1; j++)
                {
                    if (a1[j, 1] < a1[j + 1, 1] || (a1[j, 1] == a1[j + 1, 1] && a1[j, 0] > a1[j + 1, 0]))
                    {
                        // swap arr[j+1] and arr[i]
                        var temp = a1[j, 0];
                        a1[j, 0] = a1[j + 1, 0];
                        a1[j + 1, 0] = temp;
                        temp = a1[j, 1];
                        a1[j, 1] = a1[j + 1, 1];
                        a1[j + 1, 1] = temp;
                    }
                }
            }

            return a1;
        }

        // This method returns count
        // of Unique elements
        private static int countDistinct(int[] arr, int n)
        {

            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                // add all the elements to the HashSet
                hs.Add(arr[i]);
            }

            // return the size of hashset as
            // it consists of all Unique elements
            return hs.Count;
        }
    }
}
