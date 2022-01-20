using System;

namespace GeekBraineslessons
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;            
            double D = a + (b * c);
            Console.WriteLine($"буква первая {a},\n буква вторая {b},\n буква третия {c}\n и буква четвёртая {D}\n");
            Console.ReadKey();
        }
    }
}
