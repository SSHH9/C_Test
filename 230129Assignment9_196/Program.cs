using System;
using System.Collections.Generic;

namespace _230129Assignment9_196
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

            int index = ohlc[0].IndexOf("close");

            for (int i = 1; i < 4; i++)
            {
                int data = int.Parse(ohlc[i][index]);

                if (data > 150)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
