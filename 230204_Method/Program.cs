using System;
using System.Collections.Generic;

namespace _230204_Method
{
    class Program
    {
        static void print_5(string a)
        {
            char[] arr = a.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i%5 == 0 && i != 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(arr[i]);
                
                //if (i%5 == 0)
                //{
                //    Console.WriteLine()
                //}
                //Console.Write()
            }
            
           
            
        }

        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //List<int> score = new List<int> { 1,2,3 };

            print_5("ABCDEFGHIJ");
        }
    }
}
