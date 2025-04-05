using System;

namespace MyOperations
{
    public class Operations
    {
        public static void Divide(int numerator, int denominator)
        {
            try
            {
                if (denominator == 0)
                {
                    throw new DivideByZeroException();
                }

                int result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(1001, "Division by zero is not allowed.");
            }
        }
        public static void AccessArrayElement(int[] arr, int index)
        {
            try
            {
                Console.WriteLine($"Element at index {index}: {arr[index]}");
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(1002, "Array index is out of bounds.");
            }
        }
    }
}
