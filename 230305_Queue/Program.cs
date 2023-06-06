using System;
using System.Collections.Generic;

namespace _230305_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueAA = new Queue<int>();
            queueAA.Enqueue(1);
            queueAA.Enqueue(2);

            for (int i = 0; i < 10; i++)
            {
                queueAA.Enqueue(i);
            }
            Console.WriteLine("Queue Data: {0}", queueAA.Peek());

            while (queueAA.Count > 0)
            {
                Console.WriteLine("Queue Data: {0}, Count: {1}", queueAA.Dequeue(), queueAA.Count);
            }

            Console.WriteLine("\nInitialize");

            string[] arrData = { "AA", "BB", "CC" };

            Queue<string> queueArr = new Queue<string>(arrData);

            foreach (var item in queueArr)
            {
                Console.WriteLine("QueueArr Data: {0}", item);
            }
        }
    }
}
