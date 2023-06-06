using System;
using System.Collections.Generic;

namespace _230204
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

            int index_open = ohlc[0].IndexOf("open");
            int index_high = ohlc[0].IndexOf("high");
            int index_low = ohlc[0].IndexOf("low");
            int index_close = ohlc[0].IndexOf("close");

            int sum = 0;
            for (int i = 1; i < 4; i++)
            {
                int open = Convert.ToInt32(ohlc[i][index_open]);
                int high = Convert.ToInt32(ohlc[i][index_high]);
                int low = Convert.ToInt32(ohlc[i][index_low]);
                int close = Convert.ToInt32(ohlc[i][index_close]);

                sum += close - open;
            }
            Console.WriteLine(sum);


        }
    }
}
