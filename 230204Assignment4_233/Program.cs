using System;
using System.Collections.Generic;

namespace _230204Assignment4_233
{
    class Program
    {
        static List<string> make_list(string a)
        {
            char[] ca = a.ToCharArray();

            List<string> list = new List<string> { };

            foreach (var item in ca)
            {
                list.Add(item.ToString());
            }

            

            return list;    
        }
        static void Main(string[] args)
        {
            List<string> list = make_list("abcd");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
