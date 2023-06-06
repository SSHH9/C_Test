using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230402_TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0;
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Input String: ");
                string readStr = Console.ReadLine();

                try
                {
                    inputNum = int.Parse(readStr);
                    isCorrect = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Input String: " + readStr + " Input Int. ");
                }
            }
            Console.WriteLine("InputNum: " + inputNum);
        }
    }
}
