using System;

namespace _221127_class_Super_Sub2
{
    class Super
    {
        protected int a;

        public Super()
        {
            a = 100;
            Console.WriteLine(" Call Super 생성자 호출");
        }

        ~Super()
        {
            a = 100;
            Console.WriteLine(" Call Super 소멸자 호출");
        }
    }

    class Sub: Super
    {
        public Sub()
        {
            a = 100;
            Console.WriteLine(" Call Sub 생성자 호출");
        }

        ~Sub()
        {
            a = 100;
            Console.WriteLine(" Call Sub 소멸자 호출");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub(); //부모가 먼저 생성된 후 자식이 나중에 생성됨
        }
    }
}
