using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionsByMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Заранее инициализируем массивы по заданию - красивее и удобнее, 
            //все в одном месте.
            int[] number = new int[5] { -20, 1, 51, -85, -9 };
            int[] numberTwo = new int[10];
            int[] number3 = new int[5] { 6, 31, 1, 45, 54 };


            //Задание нумбер рас
            TaskOne(number);


            //Задание нумбер 2
            TaskTwo(numberTwo);


            //Задание нумбер 3
            TaskTree(number3);






            Console.ReadKey();
        }

        static void TaskOne(int[] num)
        {

            int positiveNumber = 0;
            int negativeNumber = 0;

            Console.WriteLine("Задание нумбер раз");
            Console.WriteLine("");
            Console.WriteLine("");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > 0)
                    positiveNumber++;
                else if (num[i] < 0)
                    negativeNumber++;


            }
            Console.WriteLine($"Положительных  чисел {positiveNumber} а отрицательных {negativeNumber}");

        }

        static void TaskTwo(int[] num)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Задание нумбер 2");
            Console.WriteLine("");
            Console.WriteLine("");
            int summLastNumbers;
            int lastNumber1 = 1;
            int lastNumber2 = 0;
            Console.WriteLine("Числа Фиббоначи от 1 до 10 по порядку:");
            for (int i = 0; i < num.Length; i++)
            {
                summLastNumbers = lastNumber1 + lastNumber2;
                num[i] = (summLastNumbers);
                lastNumber1 = lastNumber2;
                lastNumber2 = summLastNumbers;
                Console.WriteLine(num[i]);

            }
        }

        static void TaskTree(int[] num)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Задание нумбер 3");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Сортировка массива в порядке возрастания:");
            Array.Sort(num);
            Array.ForEach(num, Console.WriteLine);

        }


    }
}
