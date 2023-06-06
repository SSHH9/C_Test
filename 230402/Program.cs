using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230402
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] per = new string[] { "10.31", "", "8.00" };
            //List<float> list = new List<float>();
            //foreach (string s in per)
            //{
            //    try
            //    {
            //        //Console.WriteLine(float.Parse(s));
            //        list.Add(float.Parse(s));
            //    }
            //    catch (Exception e) 
            //    {
            //        //Console.WriteLine(0);
            //        list.Add(0);
            //    }
                
            //}

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            int a = int.Parse(Console.ReadLine());

            try
            {
                float b = 3 / a;
                Console.WriteLine(b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
