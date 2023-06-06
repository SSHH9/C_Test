﻿using System;
using System.Collections.Generic;

namespace _230129Assignment11_198
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> ohlc = new List<List<string>>
            {
                new List<string> { "open", "high", "low", "close" },
                new List<string> { "100", "110", "70", "100" },
                new List<string> { "200", "210", "180", "190" },
                new List<string> { "300", "310", "300", "310" },
            };

            List<int> volatility = new List<int> { };

            int index_high = ohlc[0].IndexOf("high");
            int index_low = ohlc[0].IndexOf("low");

            for (int i = 1; i < 4; i++)
            {
                int high = int.Parse(ohlc[i][index_high]);
                int low = int.Parse(ohlc[i][index_low]);

                volatility.Add(high - low);                                
            }
            foreach (var item in volatility)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}
