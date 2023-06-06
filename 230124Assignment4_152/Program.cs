using System;
using System.Collections.Generic;

namespace _230124Assignment4_152
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, 100, 23, 44 };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] %3 == 0)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
