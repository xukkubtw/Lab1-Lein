using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Modules
{
    public static class InputModule
    {
        public static int ReadInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
    }
}
