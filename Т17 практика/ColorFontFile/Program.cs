using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorFontFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Сергей\Desktop\Синержи\СиШарп\ColorFontFileForTest";

            if (Directory.Exists(path))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Подкаталоги: ");

                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                    Console.WriteLine(dir);
            }
            




            Console.ReadLine();
        }
    }
}
