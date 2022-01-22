using System;
public class Swap_Without_3rd_Var
{
    public static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;

        Console.WriteLine("Before: num1 = " + num1 + " num2 = " + num2);

        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;

        Console.WriteLine("After: num1 = " + num1 + " num2 = " + num2);
    }
}