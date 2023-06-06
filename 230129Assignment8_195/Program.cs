using System;
using System.Collections.Generic;

namespace _230129Assignment8_195
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<object>> ohlc = new List<List<object>>
            {
                new List<object> { "open", "high", "low", "close" },
                new List<object> { 100, 110, 70, 100 },
                new List<object> { 200, 210, 180, 190 },
                new List<object> { 300, 310, 300, 310 },
            };

            int index = ohlc[0].IndexOf("close");

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine(ohlc[i][index]);
            }
            
            
        }
    }
}
