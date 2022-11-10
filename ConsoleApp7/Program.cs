using System;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);

                dirInfo.Delete(true); 
                Console.WriteLine("Каталог удален");

                DirectoryInfo dirInfo2 = new DirectoryInfo(@"/Users/luft/Desktop/testFolder");
                string trashPath = "/Users/luft/.Trash/testFolder";

                dirInfo.MoveTo(trashPath);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
