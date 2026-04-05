using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Modules
{
    public static class ValidationModule
    {
        public static bool IsValid(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                Console.WriteLine("Оба числа не могут быть равны 0");
                return false;
            }
            return true;
        }
    }
}
