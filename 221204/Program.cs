using System;

// virtual = 오버라이딩이 가능하다는 것


namespace _221204
{
    class Base
    {
        int num;
        public void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }

    class AA : Base
    {
        int a;
        public void PrintA()
        {
            Console.WriteLine("a: {0}", a);
        }
    }

    class BB : Base
    {
        int b;
        public void PrintB()
        {
            Console.WriteLine("b: {0}", b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            Base aa = new AA(); //앞쪽에 부모, 뒷쪽에 자식
            aa.Print();         //Base 형태로 만들었기 때문에 num이 출력됨

            if (aa is BB)
            {
                Console.WriteLine("aa는 BB의 객체입니다.");
            }
            else if (aa is AA)
            {
                Console.WriteLine("aa는 AA의 객체입니다.");
            }


            Base bb = new BB();     //bb는 Base 클래스
            BB copyBB = bb as BB;   //bb를 BB 클래스로 강제로 형변환 시킴

            if (null != copyBB)
            {
                copyBB.PrintB();
            }


            Base copyAA = bb as AA;
            if (null == copyAA)
            {
                copyAA = new AA();  //copyAA는 새로 AA 클래스로 만들어짐(Base보다 AA가 더 작은 그릇)
                copyAA.Print();     //현재 Base copyAA 형태라서 Base에 속한 함수밖에 사용 못함
                AA asAA = copyAA as AA; //AA 클래스의 함수를 쓰고 싶으면 다시 강제 형변환을 해주어야함
                asAA.PrintA();
            }
        }
    }
}
