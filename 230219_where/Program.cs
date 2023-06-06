using System;

namespace _230219_where
{
    class REF { }
    class AA<T> where T: struct //값형식으로 제한
    {
        private T sData;
        public AA()
        {
            sData = default(T);
        }
        public void Print()
        {
            Console.WriteLine("sData: " + sData);
        }
    }
    class BB<T> where T: class //참조 형식으로 제한
    {
        private T sRefData;
        public BB()
        {
            sRefData = default(T);
        }
        public void Print()
        {
            if (sRefData == null) Console.WriteLine("Null sRefData");
            Console.WriteLine("sRefData:" + sRefData);
        }
    }
    interface II
    {
        void IIPrint();
    }
    class CC<T> where T:II  //interface로 제한
    {
        public T _interface;
    }
    class DD : II
    {
        public void IIPrint()
        {
            Console.WriteLine("DDbase: ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //AA<REF> bb = new AA<REF>();   //오류: AA는 null을 허용하지 않는 value형식. REF는 class형식으로 참조형식.
            AA<int> aa = new AA<int>();
            aa.Print();

            //BB<int> bb = new BB<int>();     //오류: BB는 참조형식, int는 값형식.
            BB<REF> bb = new BB<REF>();
            bb.Print();

            CC<II> cc = new CC<II>();
            //cc._interface = new REF();        //오류: 한정자가 interface
            cc._interface = new DD();
            cc._interface.IIPrint();
        }
    }
}
