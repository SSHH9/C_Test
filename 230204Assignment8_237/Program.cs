using System;

namespace _230204Assignment8_237
{
    class Program
    {
        private static int method(int num)
        {
            return num + 4;
        }
        static void Main(string[] args)
        {
            int c = method(method(method(10))); //14->18->22
            Console.WriteLine(c);   //22
        }
    }
}
