﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230409Homework3
{
    delegate void del(List<string> strList);
    internal class Program
    {
        static public void WordCheck(List<string> strList)
        {
            foreach (var str in strList)
            {
                if (str.Length <= 3)
                {
                    Console.WriteLine(str);
                }
            }
            
        }
        static void Main(string[] args)
        {
            List<string> animals = new List<string>() { "cat", "tiger", "dog", "bird", "monkey" };

            WordCheck(animals);

            del WordCheckLambda = (strList) =>
                {
                    foreach (var str in strList)
                    {
                        if (str.Length <= 3)
                        {
                            Console.WriteLine(str);
                        }
                    }
                };
            WordCheckLambda(animals);

        }
    }
}
