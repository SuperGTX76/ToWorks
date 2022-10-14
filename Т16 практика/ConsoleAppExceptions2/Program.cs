using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExceptions2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int tankCapacity = 2000;                        //Общий объем воды в резервуаре
                int consumptionWater = 500;                     //Сколько воды забрали
                int replenishmentWater = -500;                  //Сколько воды пришло

                TakeWater(ref tankCapacity, consumptionWater, replenishmentWater);
                TakeWater(ref tankCapacity, consumptionWater, replenishmentWater);
                TakeWater(ref tankCapacity, consumptionWater, replenishmentWater);
                TakeWater(ref tankCapacity, consumptionWater, replenishmentWater);



                Console.ReadLine();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


            
        }

        static void TakeWater(ref int tankCapacity, int consumptionWater, int replenishmentWater)
        {
            if (tankCapacity > consumptionWater) 
            {
                
                tankCapacity -= consumptionWater;

                Console.WriteLine("Поменьше, поменьше воды набирай!!! Она, чай, не козённая!!!");
                Console.WriteLine($"Осталось то всего ничего - {tankCapacity} литров!!");
                Console.WriteLine("Такими темпами, мне скоро, и поллитру запить нечем будеть!!!");
                Console.WriteLine("");
            } 
            else if (tankCapacity <=500)
            {
                
                Console.WriteLine("Все!!! Все что нажито непосильным трудом - все украли!!!");
                Console.WriteLine("Три куртки кожаных, три магнитафона импортных... ");
                Console.WriteLine("Воды то, воды то из озера сколько унесли... Тоже три!!! :)");
                Console.WriteLine("");
                tankCapacity = 0;
                Console.WriteLine("База, база, у меня тут как в Каракумах уже!!! Открывай давай свой Учкудук!!!"); 
                Console.WriteLine("");
                Console.WriteLine("Бульк...");
                Console.WriteLine("");
                if (replenishmentWater < 0) 
                {
                    //Правильным решением является tankCapacity += replenishmentWater * -1;
                    Console.WriteLine("Эй-эй, ты какой кран там открываешь? Савсем снег башка попал, да?");
                    Console.WriteLine("Давай этот кран закрывай, правильный открывай!");
                    throw new ArgumentException("Исключение: Количество подаваемой воды не может быть отрицательным");
                }
            }
        }
    }
}
