using System;
using System.Collections.Generic;

namespace _230124Assignment6_154
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "I", "study", "python", "language", "!"  };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length >= 3)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
