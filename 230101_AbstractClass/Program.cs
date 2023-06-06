using System;

namespace _230101_AbstractClass
{
    abstract class abstractAA                   // 밑에 abstract 쓰려면 class 가 abstract 여야 함!!!!
    {
        public int num;
        public abstract void abstractPrint();   // 강제적으로 상속받은 클래스에서 구현부( public override void abstractPrint() 무문 )를 정의해야 함

        public virtual void virtualPrint()      // 강제적으로 구현부 정의하지 않아도 됨. (override 할 수는 있음)
        {                                       // 대신 { } 요 부분 있어야 함

        }

        public void Print()
        {

        }
    }

    class AA : abstractAA
    {
        public override void abstractPrint()    
        {
            Console.WriteLine("abstractPrint");
        }

        public override void virtualPrint()
        {
            base.virtualPrint();
            Console.WriteLine("override void virtualPrint");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.abstractPrint();
            aa.virtualPrint();

            abstractAA aa2 = new AA();  // 원래는 오류가 났었음 (위쪽에서 구현되지 않았을경우 오류가 날 확률이 높아서 막아놨었는데 지금은 되나봄)
        }
    }
}
