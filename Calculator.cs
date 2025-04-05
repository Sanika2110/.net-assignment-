using System;

class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public double Subtract(double a, double b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public double Multiply(double a, double b) => a * b;

    public virtual double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}

class AdvancedCalculator : Calculator
{
    public override double Divide(double a, double b)
    {
        try
        {
            return base.Divide(a, b);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            return double.NaN;
        }
    }
}

class Calculator
{
    static void Main()
    {
        Calculator calc = new AdvancedCalculator();
        while (true)
        {
            Console.WriteLine("\nMenu-Driven Calculator:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 5) break;

            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;
            switch (choice)
            {
                case 1:
                    result = calc.Add(num1, num2);
                    break;
                case 2:
                    result = calc.Subtract(num1, num2);
                    break;
                case 3:
                    result = calc.Multiply(num1, num2);
                    break;
                case 4:
                    result = calc.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    continue;
            }
            Console.WriteLine("Result: " + result);
        }
    }
}
