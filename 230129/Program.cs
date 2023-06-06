using System;
using System.Collections.Generic;

namespace _230129
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> apart = new List<List<string>>() {
                new List<string> {"101호", "102호"},
                new List<string> {"201호", "202호"},
                new List<string> {"301호", "302호"},
            };

            for (int i = 2; i > -1; i--)
            {
                for (int j = 1; j > -1; j--)
                {
                    Console.WriteLine(apart[i][j]);
                }
            }

        }
    }
}
