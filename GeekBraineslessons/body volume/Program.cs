using System;

namespace Привет___рост__вес_и_объёим_тела
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую!");
            Console.Write("Как вас зовут?");
            String name = Console.ReadLine();
            Console.Write("Какая у вас фамилия?");
            String f = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            String e = Console.ReadLine();
            Console.Write("Ваш рост?");
            String b = Console.ReadLine();
            Console.Write("Сколько вы весите?");
            String w = Console.ReadLine();
            int i = Convert.ToInt32(w) / (Convert.ToInt32(b) * Convert.ToInt32(b));   //не получается формулой расчитать кого во что  нужно  конвертировать?
            Console.WriteLine($"рад с вами познакомиться {name} {f}");
            Console.WriteLine($"Ваш рост {b}, вес {w}, возраст {e} и объём тела {i}");
            Console.ReadKey();
        }
    }
}
