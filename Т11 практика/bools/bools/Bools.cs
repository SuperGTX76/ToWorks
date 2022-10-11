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
            Console.WriteLine(" ");
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
                return;
            }
                else if (conditionSelect == "0") 
                {
                    Console.WriteLine("Боязно, да? Ну на это я и рассчитывал! :)))");
                    return;
                }
                else 
                {
                
                }
                


            
            Console.ReadLine();
        }
    }
}
