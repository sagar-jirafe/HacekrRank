using System;

public class GFG
{
    public static void Main(String[] args)
    {
        string s = Console.ReadLine(); 
        char[] rev = s.ToCharArray(); 
        Array.Reverse(rev); 
        string revs = new string(rev);

        Console.WriteLine(s.Equals(revs) ? "Palindrome" : "Not Palindrome");
    }
}