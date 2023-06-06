using System;
using System.Collections.Generic;

namespace _230124Assignment11_159
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "intra.h", "intra.c", "define.h", "run.py" };

            for (int i = 0; i < list.Count; i++)
            {
                string[] a = list[i].Split('.');

                if (a[1].Contains('h'))
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
