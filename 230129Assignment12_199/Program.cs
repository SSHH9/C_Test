using System;
using System.Collections.Generic;

namespace _230129Assignment12_199
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

            int index_open = ohlc[0].IndexOf("open");
            int index_high = ohlc[0].IndexOf("high");
            int index_low = ohlc[0].IndexOf("low");
            int index_close = ohlc[0].IndexOf("close");

            for (int i = 1; i < 4; i++)
            {
                int open = int.Parse(ohlc[i][index_open]);
                int high = int.Parse(ohlc[i][index_high]);
                int low = int.Parse(ohlc[i][index_low]);
                int close = int.Parse(ohlc[i][index_close]);

                if (close > open)
                {
                    Console.WriteLine(high - low);
                }
            }

        }
    }
}
