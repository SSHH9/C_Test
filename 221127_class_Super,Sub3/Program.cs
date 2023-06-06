using System;

namespace _221127_class_Super_Sub3
{
    class Super
    {
        int num;
        protected string name;

        public Super(int num)
        {
            this.num = num;
        }

        public void PrintSuper()
        {
            Console.WriteLine("Super num: {0}", num);
        }
    }

    class Sub : Super
    {
        string name;

        public Sub(int num, string name) : base(num)
        {
            this.name = name;
        }

        public void PrintSub()
        {
            base.name = "Super";    //base는 부모클래스. 부모클래스의 name을 "Super"로 바꾸겠다.
            base.PrintSuper();

            Console.WriteLine("Super name: {0}", base.name);
            Console.WriteLine("Sub name: {0}", this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sub sub = new Sub(26, "Jack");
            sub.PrintSub();
        }
    }
}
