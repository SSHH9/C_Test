    using System;
    using System.Collections.Generic;

namespace _230124Assignment3_151
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, -20, -3, 44 };

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
