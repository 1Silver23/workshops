using System;

class Program
{
    static void Main()
    {
        int a, b, min;
        Console.WriteLine("Введите два целых числа.");
        Console.Write("Введите первое число:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число:");
        b = Convert.ToInt32(Console.ReadLine());

        if (a < b)
        {
            min = b;
        }
        else
        {
            min = a;
        };
        Console.WriteLine("Наибольшее число {0}", min);
        Console.WriteLine("Для выхода из приложение нажмите Enter");
        Console.ReadLine();
    }
}
