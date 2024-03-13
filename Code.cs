using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;
        int total = Add(num1, num2);
        Console.WriteLine("The total is: " + total);
        ProvideFeedback(total);
    }

    static int Add(int x, int y)
    {
        return x + y;
    }

    static void ProvideFeedback(int result)
    {
        Console.WriteLine("The result is: " + result);
        if (result > 10)
            Console.WriteLine("Wow! That's a big number!");
        else if (result > 5)
            Console.WriteLine("That's a decent number.");
        else
            Console.WriteLine("Eh, that's a small number.");
    }
}
