using System;

namespace _230115_Generic2
{
    class GenericAA<T>
    {
        private T num;
        public T getNum()
        {
            return num;
        }
        public void SetNum(T data)
        {
            num = data;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericAA<int> AA = new GenericAA<int>();
            AA.SetNum(100);
            Console.WriteLine("AA: " + AA.getNum());

            GenericAA<float> BB = new GenericAA<float>();
            BB.SetNum(100.30f);
            Console.WriteLine("BB: " + BB.getNum());
        }
    }
}
