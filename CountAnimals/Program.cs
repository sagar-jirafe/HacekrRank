/*
 Let the total no. of Heads = 200 and Legs = 540. 
Let the number of Head and Legs of Rabbits = X and that of Pigeons = Y. 
so, 
X + Y = 200 ..equation 1 (no. of the heads of a rabbit and a pigeon = total no. of heads) 
(As both of them has 1 head) 
4X + 2Y = 540 …equation 2 (no. of the legs of the rabbit and a pigeon = total no. of legs) 
(Rabbit have 4 legs and pigeons have 2 legs) 
Now, solving equation 1 and 2 we get, 
4X = 540 – 2Y 
4X = 540 – 2 * (200 – X) 
4X = 540 – 400 + 2X 
2X = 140 => X = 70
X = 70 and Y = 130. 
hence, Rabbits = 70 and Pigeons = 130 
 */

using System;
public class CountAnimals
{
    public static void Main()
    {
        int Heads = 100, Legs = 300;

        int Rabbits = CountAnimal(Heads, Legs);

        Console.WriteLine("Rabbits = " +
                           Rabbits);
        Console.WriteLine("Pigeons = " +
                         (Heads - Rabbits));
    }

    public static int CountAnimal(int Heads, int Legs)
    {
        int count = Legs - 2 * Heads;
        count = count / 2;
        return count;
    }
}