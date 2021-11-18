using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectoy = @"C:\Users\Laptop\Documents\TKTK\samples";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();

            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            //loome kausta sissa faili
            

            Directory.CreateDirectory($"{rootDirectoy}\\{newDirectory}");

            //File.Create($"{rootDirectoy}\\{newDirectory}\\{fileName}");

            if (Directory.Exists($"{rootDirectoy}\\{newDirectory}") && File.Exists($"{rootDirectoy}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and file exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectoy}\\{newDirectory}");
                File.Create($"{rootDirectoy}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
