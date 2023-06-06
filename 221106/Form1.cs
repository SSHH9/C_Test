using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221106
{
    class AA
    {
        ////멤버 변수
        //int num1;
        //public int num2, num3;

        ////멤버 함수
        //public void Print()
        //{
        //    Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        //}


        //int a;

        //public AA() //생성자
        //{
        //    a = 0;  //값을 초기화. 리뉴얼

        //    Console.WriteLine("  Call Constructor   ");
        //    Console.WriteLine("  a : {0}", a);
        //}

        //~AA()   //소멸자
        //{
        //    Console.WriteLine("   Call Destructor   ");
        //}





        ///3
        //public int a1; //멤버 변수
        //public AA(int a2)
        //{
        //    this.a1 = a2;
        //}


        ///4 --> 3보다 4를 더 많이 씀(a1가 private이라서 보완유지가능)
        //int a1; //멤버 변수
        //public AA(int a2)
        //{
        //    this.a1 = a2;
        //}

        //public void Print()
        //{
        //    Console.WriteLine("a: {0}", a1);
        //}


        ///5
        //public static int a;
        //public static int b;
        //public int c;

        ////정적 함수에서는 반드시 정적 변수만 참조 가능
        //public static void Print()
        //{
        //    Console.WriteLine("a: {0}", a);
        //    Console.WriteLine("b: {0}", b);

        //    //Console.WriteLine("c: {0}", c); //error
        //}



        ///7
        public int a;
        public int b;

        public AA()
        {
            a = 0;
            b = 0;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

        }
    }

    /// 6
    //class BB
    //{
    //    public int a;
    //    public int b;
    //    public void Print()
    //    {
    //        Console.WriteLine("a: {0}", a);
    //        Console.WriteLine("b: {0}", b);

    //    }
    //}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //AA aa = new AA();   // 클래스의 새로운 객체 생성
            //aa.Print(); //객체.함수()



            ////clss Person - 변수 : eye, nose, mouth
            ////            - 함수 : walk, run, eat

            ////김설하 - walk() -> 일자로 걷는다
            ////최유라 - walk() -> 팔자로 걷는다

            ////Person 김설하 = new Person("일자");
            ////김설하.walk();
            ///

            ///3
            //AA instance = new AA(10);
            //AA test = new AA(20);
            //int a = instance.a1;

            ///4
            //AA instance = new AA(10);
            //instance.Print();


            ///5
            //AA.a = 10; //객체 생성 없이 바로 접근
            //AA.b = 100; //객체 생성 없이 바로 접근

            //AA.Print();

            ///6
            ////BB.a = ~~~ //오류 - 객체를 만들어서 사용해야 함
            ////BB.b       //오류
            ////BB.Print() //오류

            //BB bb = new BB();
            //bb.a = 100;
            //bb.b = 200;
            //bb.Print();


            ///7
            AA aa = new AA();
            aa.Print();

            CopyRefClass(aa);
            aa.Print(); //100,10000

            ///8
            AA aaa = CopyDeepClass(aa);
            aaa.Print(); //0,10000

            aa.Print(); //100,10000
        }

        ///7
        static void CopyRefClass(AA aa)
        {
            AA refAA = aa; //같은 주소값
            refAA.a = 100;
            refAA.b = 10000;
        }

        ///8
        static AA CopyDeepClass(AA aa)
        {
            AA tempAA = new AA();

            tempAA.a = aa.a;
            tempAA.b = aa.b;

            tempAA.a = 0;

            return tempAA;
        }
    }
}
