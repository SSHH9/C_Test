﻿using System;

namespace _230204Assignment3_232
{
    class Program
    {
        static void make_url(string a)
        {
            Console.WriteLine("www." + "{0}" + ".com", a);
        }
        static void Main(string[] args)
        {
            make_url("naver");
        }
    }
}
