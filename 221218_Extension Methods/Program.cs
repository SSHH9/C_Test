using System;

namespace _221218_Extension_Methods
{
    class AA
    {
        public void PrintAA(string str)
        {
            Console.WriteLine("PrintAA {0}", str);
        }
    }
    static class Util
    {
        public static void Print(this AA aa, string str)    //확장메소드
        {
            aa.PrintAA(str);
        }
        public static void Sum(this int a)
        {
            Console.WriteLine("{0} + {1} = {2}", a, a, a + a);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            Util.Print(aa, "Hello");
            aa.Print("Hello");  //상속 안했지만 14번째 줄의 this AA aa를 처음으로 불러와서 Print의 두번째 파라미터만 적어도 됨

            Util.Sum(10);
            10.Sum();   //상속을 안하고도 이미 만들어진 클래스에서 추가 확장할 수 있는 방법
        }
    }
}
