
using System;

public class ReverseString_Without_Changing_Sp_Char
{
    public static void Main()
    {
        String str = "a!!!b.c.d,e'f,ghi";
        char[] charArray = str.ToCharArray();

        Console.WriteLine("Input string: " + str);
        Reverse(charArray);
        String revStr = new String(charArray);

        Console.WriteLine("Output string: " + revStr);
    }

    public static void Reverse(char[] str)
    {
        // Initialize left and right pointers
        int r = str.Length - 1, l = 0;

        // Traverse string from both ends until
        // 'l' and 'r'
        while (l < r)
        {
            // Ignore special characters
            if (!char.IsLetter(str[l]))
                l++;
            else if (!char.IsLetter(str[r]))
                r--;

            // Both str[l] and str[r] are not spacial
            else
            {
                char tmp = str[l];
                str[l] = str[r];
                str[r] = tmp;
                l++;
                r--;
            }
        }
    }
}