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
            string path = @"C:\123";

            if (Directory.Exists(path))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Подкаталоги: ");

                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                    Console.WriteLine(dir);

                Console.ResetColor();
                
                string[] filesName = Directory.GetFiles(path);
                Console.WriteLine("Файлы: ");

                foreach (string files in filesName)
                {
                    if (files.EndsWith(".zip"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(files);
                    }  
                    else if (files.EndsWith(".txt"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(files);
                    }
                    else if(files.EndsWith(".pptx"))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(files);
                    }

                    Console.ResetColor();
                }


            }

            //Архивы красным,тхт зеленым, презенташки фиолетовым

            


            




            Console.ReadLine();
        }
    }
}
