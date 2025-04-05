using System;
using System.IO;

namespace FileHandlingProject
{
    class BinaryFileHandler
    {
        public static void PerformOperations()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "binaryfile.txt");

            // Writing binary data
            Console.Write("Enter a number to save in binary file: ");
            int number = int.Parse(Console.ReadLine());

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(number);
                Console.WriteLine("Binary file written successfully!");
            }

            // Reading binary data
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int readNumber = reader.ReadInt32();
                Console.WriteLine("Read from binary file: " + readNumber);
            }
        }
    }
}
