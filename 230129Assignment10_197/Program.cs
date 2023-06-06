using System;
using System.Collections.Generic;

namespace _230129Assignment10_197
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

            int index_close = ohlc[0].IndexOf("close");
            int index_open = ohlc[0].IndexOf("open");

            for (int i = 1; i < 4; i++)
            {
                int close = int.Parse(ohlc[i][index_close]);
                int open = int.Parse(ohlc[i][index_open]);

                if (close >= open)
                {
                    Console.WriteLine(close);
                }
            }
        }
    }
}
