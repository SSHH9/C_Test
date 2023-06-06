using System;
using System.Collections.Generic;

namespace _230124
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////126/////////////////////////////////
            ///
            //Q. 우편번호는 5자리로 구성되는데, 앞의 세자리는 구를 나타낸다.예를들어, 강북구의 경우 010, 011, 012 세 자리로 시작한다.

            //- 0   1   2   3   4   5   6   7   8   9
            //01  강북구 강북구 강북구 도봉구 도봉구 도봉구 노원구 노원구 노원구 노원구
            //사용자로 부터 5자리 우편번호를 입력받고 구를 판별하라

            //>> 우편번호: 01400
            //도봉구
            ///

            //A.
            //List<string> Gang = new List<string> { "010","011","012" };
            //List<string> Do = new List<string> { "013", "014", "015" };
            //List<string> No = new List<string> { "016", "017", "018","019" };

            //string a = Console.ReadLine();
            //string b = a.Substring(0, 3);

            //if (Gang.Contains(b))
            //{
            //    Console.WriteLine("Gang");
            //}
            //else if (Do.Contains(b))
            //{
            //    Console.WriteLine("Do");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            //////////////////////126/////////////////////////////////           


        }
    }
}
