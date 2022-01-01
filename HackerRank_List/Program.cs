using System;
using System.Collections.Generic;
using System.Linq;
namespace HacekrRank_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>{5, 3, 3,4, 1, 2,2,2 };

            var frequencyDict = arr.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            var sortedDict = from entry in frequencyDict orderby entry.Value ascending select entry;

            int ct = sortedDict.Count();

            int[,] result = new int[ct,2];

            int i = 0;

            foreach (KeyValuePair<int, int> item in sortedDict)
            {
                result[i,0] = item.Key;
                result[i,1] = item.Value;
                i++;
            }


            for (i = 0; i < sortedDict.Count(); i++)
            {
                Console.WriteLine("[" + result[i, 0].ToString() + "," + result[i, 1].ToString() + "]");
            }

            Console.ReadKey();

        }

        
    }
}
