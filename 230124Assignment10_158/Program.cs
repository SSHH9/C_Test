using System;
using System.Collections.Generic;

namespace _230124Assignment10_158
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "hello.py", "ex01.py", "intro.hwp" };

            for (int i = 0; i < list.Count; i++)
            {
                string[] a = list[i].Split('.');
                string b = a[0];
                Console.WriteLine(b);
            }
        }
    }
}
