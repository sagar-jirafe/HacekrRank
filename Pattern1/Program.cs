/*
1
2 4
3 6 9
4 8 12 16
*/
using System;

namespace Pattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ener a positive number: ");
            int lines = int.Parse(Console.ReadLine());

            for(int i=1; i<=lines; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
