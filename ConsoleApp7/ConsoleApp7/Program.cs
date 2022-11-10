using System;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Олег\source\repos\ConsoleApp7\Program.cs"; 

            
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }
        }
    }
}
