using ConsoleApp.Modules;
using System;

class Program
{
    static void Main(string[] args)
    {
        int a = InputModule.ReadInt("Введите первое число: ");
        int b = InputModule.ReadInt("Введите второе число: ");

        if (ValidationModule.IsValid(a, b))
        {
            ProcessingModule.FindGCD(a, b);
        }
    }
}