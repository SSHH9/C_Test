using System;

namespace _230204Assignment1_227
{
    class Program
    {
        static void print_mxn(string a,int b)
        {
            int c = a.Length / b;

            for (int i = 0; i < c+1; i++)
            {
                
                if (a.Substring(i*b).Length < b)
                {
                    Console.WriteLine(a.Substring(i * b));
                }
                else
                    Console.WriteLine(a.Substring(i*b, b));
            }


            
        }
        static void Main(string[] args)
        {
            print_mxn("ABCDEFGHIJ",3);
        }
    }
}
