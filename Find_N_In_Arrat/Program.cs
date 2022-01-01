using System;
using System.Collections.Generic;

namespace Find_N_In_Arrat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int eleToFind = 11;

            bool res = new List<int>(array).Contains(eleToFind);
            Console.WriteLine( res?"YES":"NO");
        }
    }
}
