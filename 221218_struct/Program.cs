using System;

namespace _221218_struct
{
    struct AA
    {
        public int x;
        public int y;

        //public AA() //오류 : 파라미터 없음 - class와 차이점
        //{
        //}

        public AA(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("x: {0},     y: {1}", x, x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(10, 20); // 이게 보통 class 사용방법
            aa.x = 100;
            aa.Print();

            AA aaa;                 // struct는 class와 다르게 new를 사용하지 않아도 됨
            aaa.x = 100;
            aaa.y = 200;
            aaa.Print();

            AA copyAA = aa;     //값 형식
            copyAA.x = 1000;
            copyAA.y = 2000;
            copyAA.Print();     //값 형식이라서 copy한 것만 바뀜
            aa.Print();         //값 형식이라서 원본은 그대로 
        }
    }
}
