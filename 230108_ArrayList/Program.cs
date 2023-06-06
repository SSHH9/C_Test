using System;
using System.Collections;
using System.Collections.Generic;

namespace _230108_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add("Hello");   //다양한 데이터형을 넣을수있음
            arrList.Add(10f);

            for (int i = 0; i < 10; i++)
            {
                arrList.Add(i);
            }

            foreach (object data in arrList)
            {
                Console.WriteLine("arrList data: " + data);
            }

            //배열데이터로 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            ArrayList arrCopyList = new ArrayList(arrData);

            foreach (object data in arrCopyList)
            {
                Console.WriteLine("arrCopyList data: " + data);
            }
        }
    }
}
