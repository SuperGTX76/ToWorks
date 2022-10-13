using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод исключения деления на 0.");
            Console.WriteLine("Для выброса исключения необходимо ввести в консоли два числа.");
            Console.WriteLine("Второе обязательно должно быть нулем.");
            Console.WriteLine("После этого выскочит исключение, но программа продолжит работать, ");
            Console.WriteLine("так как мы его перехватим и обработаем.");

            int valueOne = int.Parse(Console.ReadLine());
            int valueTwo = int.Parse(Console.ReadLine());

            try
            {
                int valueThree = valueOne / valueTwo;

                Console.WriteLine("Не, ну как всегда! Просил же - второе число - НОЛЬ!!!");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine("Пррраааавильной дорогой идете, товагисчи!!! ");
                Console.WriteLine("С такими исключениями мы стопудов капиталистов запобедяем!!!");

            }

            Console.WriteLine("Конец прыграммы :)");
            Console.ReadLine();
        }
    }
}
