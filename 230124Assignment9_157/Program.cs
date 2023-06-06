using System;
using System.Collections.Generic;

namespace _230124Assignment9_157
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "dog", "cat", "parrot" };            

            for (int i = 0; i < list.Count; i++)
            {
                string a = list[i].Substring(0, 1).ToUpper();
                string b = list[i].Substring(1).Trim();
                Console.WriteLine(a + b);
            }
        }
    }
}
