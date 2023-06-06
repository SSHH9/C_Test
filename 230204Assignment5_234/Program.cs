using System;
using System.Collections.Generic;

namespace _230204Assignment5_234
{
    class Program
    {
        static List<int> pickup_even(List<int> a)
        {
            List<int> list = new List<int>() { };
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i]%2 == 0)
                {
                    list.Add(a[i]);
                }
            }
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            return list;
        }
        static void Main(string[] args)
        {
            List<int> input_list = new List<int> { 3, 4, 5, 6, 7, 8 };
            List<int> list = pickup_even(input_list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}