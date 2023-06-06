using System;
using System.Collections.Generic;
using System.Linq;

namespace _230124Assignment2_129
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            int[] arr_b = a.Select(c => c - '0').ToArray();

            int Cal1 = (arr_b[0] * 2 + arr_b[1] * 3 + arr_b[2] * 4 + arr_b[3] * 5 + arr_b[4] * 6 + arr_b[5] * 7 + arr_b[7] * 8 + arr_b[8] * 9 + arr_b[9] * 2 + arr_b[10] * 3 + arr_b[11] * 4 + arr_b[12] * 5) % 11;
            int Cal2 = 11 - Cal1;

            if (Cal2 != arr_b[13])
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
