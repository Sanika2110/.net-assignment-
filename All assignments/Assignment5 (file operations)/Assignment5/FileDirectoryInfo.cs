using System;
using System.IO;

namespace FileHandlingProject
{
    class FileDirectoryInfo
    {
        public static void DisplayInfo()
        {
            Console.Write("Enter a directory path to get details (or press Enter for current directory): ");
            string path = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(path))
            {
                path = Directory.GetCurrentDirectory(); // Default to current directory
            }

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (dirInfo.Exists)
            {
                Console.WriteLine($"\n📁Directory Information for: {path}");
                Console.WriteLine($"Full Name: {dirInfo.FullName}");
                Console.WriteLine($"Creation Time: {dirInfo.CreationTime}");
                Console.WriteLine($"Last Accessed: {dirInfo.LastAccessTime}");
                Console.WriteLine($"Files in Directory:");

                FileInfo[] files = dirInfo.GetFiles();
                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"- {file.Name} | Size: {file.Length} bytes | Created: {file.CreationTime}");
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist!");
            }
        }
    }
}
