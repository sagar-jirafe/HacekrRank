using System;

public class Reverse_Number_String
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a No. to reverse");
        int Number = int.Parse(Console.ReadLine());
        int Reverse = 0;
        while (Number > 0)
        {
            int remainder = Number % 10;
            Reverse = (Reverse * 10) + remainder;
            Number = Number / 10;
        }
        Console.WriteLine("Reverse No. is {0}", Reverse);
        Console.ReadLine();


        string str = "", reverse = "";
        int Length = 0;
        Console.WriteLine("Enter a Word");
        //Getting String(word) from Console  
        str = Console.ReadLine();
        //Calculate length of string str  
        Length = str.Length - 1;
        while (Length >= 0)
        {
            reverse = reverse + str[Length];
            Length--;
        }
        //Displaying the reverse word  
        Console.WriteLine("Reverse word is {0}", reverse);
        Console.ReadLine();
    }
}
