using System;

namespace _221127_class_Super_sub
{
    class Super
    {
        protected int a; //현재 클래스, 상속받은 클래스에서 모두 접근가능

        public void Print()
        {
            Console.WriteLine("Super Print()");
        }
    }

    class Sub:Super
    {
        int b;

        public void Print() //부모 클래스와 같은 이름의 메소드를 가지고 있으면 Main에서 실행시 부모 메소드를 숨기고 실행됨
        {
            Console.WriteLine("Sub Print() a: {0}, b: {1}", a, b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub();
            sub.Print();
        }
    }
}
