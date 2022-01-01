/*
1 * 2 * 3 * 4
9 * 10 * 11 * 12
13 * 14 * 15 * 16
5 * 6 * 7 * 8
*/

using System;

namespace Pattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int m = 1;
            int i, j;
            for (i = 1; i <= n - 1; i++)
            {
                if (i != 2)
                {
                    for (j = 1; j <= n; j++)
                    {
                        Console.Write(m + "*");
                        m++;
                    }
                    Console.WriteLine();
                }
                else
                {
                    m = m + n;
                    for (j = 1; j <= n; j++)
                    {
                        Console.Write(m + "*");
                        m++;
                    }
                    Console.WriteLine();
                }
            }
            for (i = n + 1; i <= (n + n); i++)
            {
                Console.Write(i + "*");
            }
            Console.WriteLine();
        }
    }
}
