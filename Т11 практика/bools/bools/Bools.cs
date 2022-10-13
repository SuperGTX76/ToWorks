using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bools
{
    class Bools
    {
        public static void Main (String[] arg)
        {
            Console.WriteLine("bool может принимать два выраения: false либо true.  Третьго не дано.");
            Console.WriteLine("Значением по умолчанию для bool является false");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Давайте лучше сыграем в угадайку? :)");
            Console.WriteLine("Усли согласны - напишите 1, иначе 0");
            Console.WriteLine("И не забудьте Энтер нажать!!!");

            /* Здравствуйте.
             * Можно было сделать это через свитч, но я решил делать эту часть кода на if конструкиях,
             * используя для сравнения стринг, ибо невозможно предугадать, что введет особо опасный зверь с ником "ЮЗЕР" :)
             */
            string conditionSelect = Console.ReadLine();

            if (conditionSelect != "0" && conditionSelect != "1")
            {
                Console.WriteLine("Чот ты мне тут ерунду всякую несешь! Правильные цифры надо тыкать - 0 или 1 !!!");
                Console.WriteLine("Придется все по новой начинать!!!" );
                Console.Read();
                return;
            }
                else if (conditionSelect == "0") 
                {
                    Console.WriteLine("Боязно, да? Ну на это я и рассчитывал! :)))");
                    Console.Read();
                    return;
                }
            
                else 
                {
                Console.WriteLine("Да неужели в аптеки таблетки от трусости привезли???");
                Console.WriteLine("Ну, коли шутки в стороны - то правила таковы:");
                Console.WriteLine();
                Console.WriteLine("Я загадываю число, от 0 до 10");
                Console.WriteLine("Надо написать свое число, а я скажу, больше оно чем моё, или меньше.");
                Console.WriteLine("Даю всего три попытки.");
                Console.WriteLine();
                Console.WriteLine("Итак, начинаем! Вводим первое число, и не забываем нажать Энтер.");

                Random rnd = new Random();
                int myValue = rnd.Next(0, 10);
                        
                

                for (int i = 1; i < 4; i++)
                {
                    int playerValue = int.Parse(Console.ReadLine());
                    if (myValue == playerValue)
                    {
                        Console.WriteLine($"Читер!!! Угадать с {i} попытки - это ЧИТЕРСТВО!"); 
                    }
                    else if (myValue < playerValue)
                    {
                        Console.WriteLine("Непрррраааавильно Вы, дядь Федор, бутерброд жуете!!!Я такие большие числа не ззагаааааадываю :)))");
                        if (i == 3)
                        {
                            Console.WriteLine("Лууууузер! Попытки исчерпаны!");
                            break;
                        }
                    }
                    else if (myValue > playerValue)
                    {
                        Console.WriteLine("Мама Акула акуленку говорит - рот пошире разевай. Но моя цифра - ");
                        Console.WriteLine("настолько велика, что даже туда не залезет... Ваша меньше!");
                        if (i == 3)
                        {
                            Console.WriteLine("Лууууузер! Попытки исчерпаны!");
                            break;
                        }

                    }
                }
                

                        

                }
                


            
            Console.ReadLine();
        }
    }
}
