using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230409Homework2
{
    delegate bool del(int a);
    internal class Program
    {
        static public bool IsPositiveNumber(int a)
        {
            if (a > 0) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPositiveNumber(-2));

            del IsPositiveNumberLambda = (a) => 
            { 
                if (a>0) return true;
                else return false;
            };
            Console.WriteLine(IsPositiveNumberLambda(-2));
        }
    }
}
