using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _230423_Action_Func
{
    internal class Program
    {
        /////// Action - return값 없는 경우
        //static void CallAction()
        //{
        //    Console.WriteLine("CallAction");
        //}
        //static void Main(string[] args)
        //{
        //    Action aFunc;
        //    Action<int> aFunc2;
        //    Action<float, int> aFunc3;

        //    aFunc = CallAction;
        //    aFunc2 = num => Console.WriteLine("num: " + num);
        //    aFunc3 = (a, b) =>
        //    {
        //        float result = b / a;
        //        Console.WriteLine("a: " + a + " b: " + b + " result: " + result);
        //    };

        //    aFunc();
        //    aFunc2(100);
        //    aFunc3(6.0f, 10);



        ///// Func - return값 있는 경우
        static int CallFunc()
        {
            return 100;
        }
        static void Main(string[] args)
        {
            Func<int> aFunc;
            Func<int, float> aFunc2;
            Func<int, int, int> aFunc3;

            aFunc = CallFunc;
            aFunc2 = (int a) => { return (float)(a / 2.0f); };
            aFunc3 = (a, b) => (a + b);

            Console.WriteLine("aFunc: " + aFunc());
            Console.WriteLine("aFunc2: " + aFunc2(10)); ;
            Console.WriteLine("aFunc3: " + aFunc3(100,100));
        }
    }
}
