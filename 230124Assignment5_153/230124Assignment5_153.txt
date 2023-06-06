using System;
using System.Collections.Generic;

namespace _230124Assignment5_153
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 13, 21, 12, 14, 30, 18 };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 3 == 0 && list[i] < 20)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
