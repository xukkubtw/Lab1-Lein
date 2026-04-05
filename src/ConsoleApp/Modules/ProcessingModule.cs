using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Modules
{
    public static class ProcessingModule
    {
        public static void FindGCD(int a, int b)
        {
            int originalA = a;
            int originalB = b;

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine($"НОД чисел {originalA} и {originalB} = {a}");
        }
    }
}
