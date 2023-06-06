using System;
using System.Collections.Generic;

namespace _230129Assignment4_191
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> data = new List<List<int>>() {
                new List<int> {2000, 3050, 2050, 1980},
                new List<int> {7500, 2050, 2050, 1980},
                new List<int> {15450, 15050, 15550, 14900},
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(data[i][j] * 1.00014);
                }
            }
        }
    }
}
