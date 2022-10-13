using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание нумбер раз");
            Console.WriteLine("");
            Console.WriteLine("");

            int positiveNumber = 0;
            int negativeNumber = 0;
            int[] number = new int[5] { -20, 1, 51, -85, -9 };
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                    positiveNumber++;
                else if (number[i] < 0)
                    negativeNumber++;

                
            }
            Console.WriteLine($"Положительных  чисел {positiveNumber} а отрицательных {negativeNumber}" );


            //Задание нумбер 2
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Задание нумбер 2");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Числа Фиббоначи от 1 до 10 по порядку:");
            int[] numberTwo = new int[10];
            int summLastNumbers;
            int lastNumber1 = 1;
            int lastNumber2 = 0;
            for (int i = 0; i < numberTwo.Length; i++)
            {
                summLastNumbers = lastNumber1 + lastNumber2;
                numberTwo[i] = (summLastNumbers);
                lastNumber1 = lastNumber2;
                lastNumber2 = summLastNumbers;
                Console.WriteLine(numberTwo[i]);

            }



            //Задание нумбер 3
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Задание нумбер 3");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Сортировка массива в порядке возрастания:");
            int[] number3 = new int[5] { 6, 31, 1, 45, 54 };


            Array.Sort(number3);
            Array.ForEach(number3, Console.WriteLine);

            Console.ReadLine();
        }
    }
}
