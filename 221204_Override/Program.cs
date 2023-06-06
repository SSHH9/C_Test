using System;

namespace _221204_Override
{
    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }

    class AA : Super
    {
        public int a;
        public override void Print()
        {
            base.Print();   //덮어쓰는 것이 아니라 추가적으로 Base 기능에 추가할때. Base 함수 먼저 실행 후 밑에 코드 실행

            Console.WriteLine("AA a: {0}", a);
        }
    }

    class BB : Super
    {
        public int b;
        public override void Print()
        {
            base.Print();   

            Console.WriteLine("BB b: {0}", b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();
            super.Print();

            Super aa = new AA();
            aa.Print();

            Super bb = new BB();
            bb.Print();
        }
    }
}
