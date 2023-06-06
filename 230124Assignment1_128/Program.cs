using System;
using System.Collections.Generic;

namespace _230124Assignment1_128
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a.Substring(8, 2));

            if (0 <= b && b <= 8)
            {
                Console.WriteLine("Seoul");
            }
            else
            {
                Console.WriteLine("Not Seoul");
            }
        }
    }
}
