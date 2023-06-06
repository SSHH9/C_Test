﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230402_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 10;
            
            try
            {
                checked //overflow 체크용
                {
                    maxNum += Int32.MaxValue;
                }
            }
            catch(OverflowException e)
            {
                Console.WriteLine("e.Message: " + e.Message);
                Console.WriteLine("e.Source: " + e.Source);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("maxNum: " + maxNum);
        }
    }
}
