using System;
using System.Linq;

public class LINQToArray
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
