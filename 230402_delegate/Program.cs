using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230402_delegate
{
    delegate int DelegateFunc(int a);  
    internal class Program
    {
        static int Add(int a)
        {
            Console.WriteLine("Add");
            return a + a;
        }
        static void Main(string[] args)
        {
            DelegateFunc delegateFunc = Add;
            Console.WriteLine("delegateFunc: " + delegateFunc(10));
        }
    }
}
