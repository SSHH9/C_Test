using System;
using System.Collections.Generic;

namespace _230219_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListAA = new List<int>();
            ListAA.Add(1);
            ListAA.Add(2);

            for (int i = 0; i < 10; i++)
            {
                ListAA.Add(i);
            }

            foreach (var data in ListAA)
            {
                Console.WriteLine("data: " + data);
            }
            Console.WriteLine("\n배열데이터로 초기화");
            string[] arrData = { "AA", "BB", "CC" };
            List<string> ListArr = new List<string>(arrData);

            for (int i = 0; i < ListArr.Count; i++)
            {
                Console.WriteLine("arrData: " + ListArr[i]);
            }
        }
    }
}
