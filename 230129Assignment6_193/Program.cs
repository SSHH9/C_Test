﻿using System;
using System.Collections.Generic;

namespace _230129Assignment6_193
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

            List<double> result = new List<double> { };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //List<double> result = new List<double> { };

                    result.Add(data[i][j] + data[i][j] * 0.00014);

                    //foreach (var item in result)
                    //{
                    //    Console.WriteLine(item);
                    //}
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
