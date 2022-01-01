using System;
using System.Linq;

namespace PaperCuts
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nm = Array.ConvertAll<string, long>(Console.ReadLine().Split(' '), Convert.ToInt64);
            Console.WriteLine(nm[0] * nm[1] - 1);

            //////////////////////////

            //var arr = Console.ReadLine().Split(' ').Select(s => long.Parse(s)).ToArray();
            //long m = Math.Max(arr[0], arr[1]);
            //long n = Math.Min(arr[0], arr[1]);

            //long cuts = m - 1 + m * (n - 1);

            //Console.WriteLine(cuts);
        }
    }
}
