using System;
using System.Collections.Generic;

namespace _230305_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stackAA = new Stack<string>();

            stackAA.Push("A");
            stackAA.Push("B");
            stackAA.Push("C");

            Console.WriteLine("Stack Data: {0}", stackAA.Peek());

            while (stackAA.Count > 0)
            {
                Console.WriteLine("Stack Data: {0}, Count: {1}", stackAA.Pop(), stackAA.Count);
            }

            Console.WriteLine("\nInitialize");

            int[] ArrData = { 100, 200, 300 };

            Stack<int> stackCopy = new Stack<int>(ArrData);

            foreach (var item in stackCopy)
            {
                Console.WriteLine(item);
            }
        }
    }
}
