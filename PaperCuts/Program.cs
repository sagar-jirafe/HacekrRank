using System;
using System.Linq;

namespace PaperCuts
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] hw = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);
            int[] h1w1 = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);

            int h = hw[0];
            int w = hw[1];

            int h1 = h1w1[0];
            int w1 = h1w1[1];


            int count = 0;

            while(h != h1)
            {
                if(h1 <= h / 2)
                {
                    count += 1;
                    h = h / 2;
                }else if(h1 > h / 2)
                {
                    count += 1;
                }
                h = Math.Abs(h - (h - h1));

            }

            while (w != w1)
            {
                if (w1 <= w / 2)
                {
                    count += 1;
                    w = w / 2;
                }
                else if (w1 > w / 2)
                {
                    count += 1;
                }
                w = Math.Abs(w - (w - w1));

            }
            Console.WriteLine(count);

            //long[] nm = Array.ConvertAll<string, long>(Console.ReadLine().Split(' '), Convert.ToInt64);
            //Console.WriteLine(nm[0] * nm[1] - 1);

            //////////////////////////

            //var arr = Console.ReadLine().Split(' ').Select(s => long.Parse(s)).ToArray();
            //long m = Math.Max(arr[0], arr[1]);
            //long n = Math.Min(arr[0], arr[1]);

            //long cuts = m - 1 + m * (n - 1);

            //Console.WriteLine(cuts);
        }
    }
}
