using System;

namespace _230204Assignment9_238
{
    class Program
    {
        private static int method1(int num)
        {
            return num + 4;
        }
        private static int method2(int num)
        {
            return num * 10;
        }
        static void Main(string[] args)
        {
            int a = method1(10);    //14
            int c = method2(a);     //140

            Console.WriteLine(c);    //140
        }
    }
}
