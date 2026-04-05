using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine("НОД = " + a);
    }
}