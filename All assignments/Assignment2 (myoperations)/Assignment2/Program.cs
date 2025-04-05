using System;
using MyOperations;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter numerator: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter denominator: ");
            int den = Convert.ToInt32(Console.ReadLine());

            Operations.Divide(num, den);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught in Main(): {ex}");
        }

        try
        {
            int[] numbers = { 10, 20, 30, 40 };
            Console.Write("Enter array index to access: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Operations.AccessArrayElement(numbers, index);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught in Main(): {ex}");
        }
    }
}
