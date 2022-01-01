/*
 Input : arr =[ 'bob', 'alice', 'bob', 'alice','bob', 'alice']
 Output: arr = ['bob', 'alice', 'bob1', 'alice1', 'bob2', 'alice2']
 */

using System;
using System.Collections.Generic;

namespace UniqueUserNameSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "bob", "alice", "bob", "alice", "bob", "alice" };
            string[] outputArr = new string[arr.Length];

            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cnt = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        cnt++;
                        if (cnt - 1 == 0)
                        {
                            outputArr[j] = arr[i];
                        }
                        else
                        {
                            outputArr[j] = arr[i] + (cnt - 1);
                        }
                    }
                }
            }
            
            for(int i=0; i < outputArr.Length; i++)
            {
                Console.WriteLine("[" + outputArr[i].ToString() + "]");
            }
        }
    }
}
