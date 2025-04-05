using System;

namespace FileHandlingProject
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Text File Operations");
                Console.WriteLine("2. Binary File Operations");
                Console.WriteLine("3. File and Directory Information");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TextFileHandler.PerformOperations();
                        break;
                    case "2":
                        BinaryFileHandler.PerformOperations();
                        break;
                    case "3":
                        FileDirectoryInfo.DisplayInfo();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}
