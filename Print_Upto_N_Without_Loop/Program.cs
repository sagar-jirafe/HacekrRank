using System;

namespace Print_Upto_N_Without_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number: ");
            int limit = int.Parse(Console.ReadLine());
            int startIndex = 1;

            printNumbers(startIndex, limit);
        }

        static void printNumbers(int startIndex, int limit)
        {

            if(startIndex <= limit)
            {
                Console.Write(startIndex + " ");
                printNumbers(startIndex + 1, limit);
            }
        }
    }
}
