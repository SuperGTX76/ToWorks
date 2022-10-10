using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            
            int[,,] array = new int[9, 9, 9];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {   
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j, k] = x;
                        Console.WriteLine($"array[{i},{j},{k}] = {array[i, j, k]}");
                        x++;
                        if (x > 9) x = 1;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
