using System;

namespace _221225_interface
{
    interface IAA
    {
        //public int a;                 //ERROR
        //private void IPrint() { };    //ERROR
        //public void IPrint();         //ERROR
        void IAAPrint();
    }

    interface IBB
    {
        void IBBPrint();
    }

    class Super
    {
        protected int num;
        public virtual void Print()
        {
            Console.WriteLine("==============================================");
        }
    }

    class AA : IAA
    {
        public void IAAPrint()
        {
            Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의");
        }
    }

    class BB : IAA, IBB
    {
        public void IAAPrint()
        {
            Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의");
        }
        public void IBBPrint()
        {
            Console.WriteLine("class BB interface IBB에 IBBPrint() 재정의");
        }
    }

    class CC : Super, IAA, IBB  //인터페이스보다 클래스가 앞쪽으로 와야함(순서가)
    {
        public override void Print()
        {
            base.Print();
            Console.WriteLine("class Super Print() 재정의");
        }
        public void IAAPrint()
        {
            Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의");
        }
        public void IBBPrint()
        {
            Console.WriteLine("class BB interface IBB에 IBBPrint() 재정의");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.IAAPrint();          //"class AA interface IAA에 IAAPrint() 재정의"

            BB bb = new BB();
            bb.IAAPrint();          //"class AA interface IAA에 IAAPrint() 재정의"
            bb.IBBPrint();          //"class BB interface IBB에 IBBPrint() 재정의"

            IAA iaa = new AA();
            iaa.IAAPrint();         //"class AA interface IAA에 IAAPrint() 재정의"

            IBB ibb = bb as IBB;
            ibb.IBBPrint();         //"class BB interface IBB에 IBBPrint() 재정의"

            CC cc = new CC();       
            cc.Print();             
            cc.IAAPrint();          
            cc.IBBPrint();

            Super sCC = cc as Super;
            sCC.Print();

            IAA IAAcc = cc as IAA;
            IAAcc.IAAPrint();

            IBB IBBcc = cc as IBB;
            IBBcc.IBBPrint();
        }
    }
}
