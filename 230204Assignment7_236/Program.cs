﻿using System;

namespace _230204Assignment7_236
{
    class Program
    {
        private static int method(int num)
        {
            return num + 4;
        }
        static void Main(string[] args)
        {
            int a = method(10); //14
            int b = method(a);  //18
            int c = method(b);  //22
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            Console.WriteLine(c);   //22
        }
    }
}
