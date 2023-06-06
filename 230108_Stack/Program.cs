using System;
using System.Collections;
using System.Collections.Generic;

namespace _230108_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();      //LIFO (Last In First Out)

            //데이터 넣어줌
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine("stack data: {0}", stack.Peek()); //값을 꺼내서 보기만하고 다시 넣음(읽기 전용) - 마지막값만 볼 수 있음

            while (stack.Count > 0)
            {
                Console.WriteLine("stack data: {0}, count: {1}", stack.Pop(), stack.Count); //값을 꺼내서 실행하고 없어짐
            }

            //배열데이터로 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Stack stackCopy = new Stack(arrData);

            foreach (object data in stackCopy)
            {
                Console.WriteLine("stackCopy data: " + data);
            }
        }
    }
}
