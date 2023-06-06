using System;
using System.Collections.Generic;

namespace _230305_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listAA = new List<int>();
            listAA.Add(1);
            listAA.Add(2);

            for (int i = 0; i < 10; i++)
            {
                listAA.Add(i);
            }
            foreach (var item in listAA)
            {
                Console.WriteLine("Data: {0}", item);
            }
            Console.WriteLine("\nInitialize");

            string[] arrData = { "AA", "BB", "CC" };

            List<string> listArr = new List<string>(arrData);

            for (int j = 0; j < arrData.Length; j++)
            {
                Console.WriteLine("ArrData: {0}", listArr[j]);
            }

        }
    }
}
