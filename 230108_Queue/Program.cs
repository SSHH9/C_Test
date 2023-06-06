using System;
using System.Collections;
using System.Collections.Generic;

namespace _230108_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();      //FIFO (First In First Out)

            //데이터 넣어줌
            queue.Enqueue("a"); 
            queue.Enqueue("b");
            queue.Enqueue("c");

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("queue data: {0}", queue.Peek()); //값을 꺼내서 보기만하고 다시 넣음(읽기 전용) - 첫번째값만 볼 수 있음
            while (queue.Count > 0)
            {
                Console.WriteLine("queue data: {0}, count: {1}", queue.Dequeue(), queue.Count); //값을 꺼내서 실행하고 없어짐
            }

            //배열데이터로 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Queue queueCopy = new Queue(arrData);

            foreach (object data in queueCopy)
            {
                Console.WriteLine("queueCopy data: " + data);
            }
        }
    }
}
