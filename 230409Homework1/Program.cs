using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230409Homework1
{
    delegate int del(int a);
    class Program
    {
        static public int MinusOne(int a)
        {
            return a - 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MinusOne(10));
            del MinusOneLambda = (int a) => a - 1; 
            Console.WriteLine(MinusOneLambda(10));
        }
    }
}
