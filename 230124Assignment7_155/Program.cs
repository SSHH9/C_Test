using System;
using System.Collections.Generic;

namespace _230124Assignment7_155
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "A", "b", "c", "D" };
            
            for (int i = 0; i < list.Count; i++)
            {
                if (char.IsUpper(list[i],0))
                {
                    Console.WriteLine(list[i]);
                }
            }

        }
    }
}
