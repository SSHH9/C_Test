﻿using System;

namespace _230204Assignment11_240
{
    class Program
    {
        private static int method0(int num)
        {
            return num * 2;
        }
        private static int method1(int num)
        {
            return method0(num + 2);
        }
        private static int method2(int num)
        {
            num = num + 10;

            return method1(num);
        }
        static void Main(string[] args)
        {
            int c = method2(2);

            Console.WriteLine(c);   //28
        }
    }
}
