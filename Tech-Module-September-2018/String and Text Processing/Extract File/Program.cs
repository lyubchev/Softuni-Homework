using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");

            string[] file = path[path.Length - 1].Split(".");
            string fileName = file[0];
            string fileExtension = file[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
