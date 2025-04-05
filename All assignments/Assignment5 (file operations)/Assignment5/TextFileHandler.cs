using System;
using System.IO;

namespace FileHandlingProject
{
    class TextFileHandler
    {
        public static void PerformOperations()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "myfile.txt");

            // Writing to a file
            Console.Write("Enter text to write to the file: ");
            string input = Console.ReadLine();
            File.WriteAllText(filePath, input);
            Console.WriteLine("File written successfully!");

            // Appending to a file
            Console.Write("Enter text to append to the file: ");
            string appendText = Console.ReadLine();
            File.AppendAllText(filePath, "\n" + appendText);
            Console.WriteLine("Text appended successfully!");

            // Reading from a file
            Console.WriteLine("\nFile Content:");
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        }
    }
}
