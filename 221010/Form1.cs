using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            ////while(true) + break//
            //int inputNum = 0;
            //while(true)
            //{

            //    Console.Write("(1)구구단 중 몇 단? (2) 나가기(0번 입력)");
            //    inputNum = int.Parse(Console.ReadLine());

            //    if (inputNum == 0)
            //    {
            //        Console.WriteLine("종료합니다");
            //        break;  //프로그램 안 터지게 할려면 무한루프에서는 필수!!
            //    }

            //    for(int i =1;i<10;i++)
            //    {
            //        Console.WriteLine("{0} x {1} = {2}", inputNum, i, inputNum * i);
            //    }
            //}



            ////continue//
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        Console.WriteLine();
            //        continue;
            //    }
            //    Console.WriteLine("i: " + i);
            //}



            ////goto//
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        goto AA;
            //    }
            //    if (i ==7)
            //    {
            //        goto BB;
            //    }
            //}

            //AA:
            //    Console.WriteLine("goto AA");
            //BB:
            //    Console.WriteLine("goto BB");




            ////method 1 - return형 없고, 파라미터 없고// 
            //InitTilte();
            //PrintEven();
            //PrintOdd();



            ////method 2 - return형 있고, 파라미터 없고//
            //int num = 0;
            //num += Add();
            //Console.WriteLine("Num: " + num);
            //Console.WriteLine("입력하신 정수는 {0} ", InputNum());




            ////method 3 - return형 있고, 파라미터 있고//
            //int a = 2;
            //int resultA = Square(a);
            //Console.WriteLine("resultA: " + resultA);

            //int b = 4;
            //int resultB = Square(b);
            //Console.WriteLine("resultB: " + resultB);

            //int resultC = Square(6);
            //Console.WriteLine("resultC: " + resultC);

            //resultC = Square(resultA * 3);
            //Console.WriteLine("resultC: " + resultC);




            ////method 4 - return형 있고, 파라미터 여러개 있고
            //int total = 0;

            //if (false == PrintDot(5,7))
            //{
            //    Console.WriteLine("PrintDot return False");
            //}
            //if (false == PrintDot(0,7))
            //{
            //    Console.WriteLine("PrintDot return False");
            //}

            //total = Total(80, 90, 100);
            //Console.WriteLine("total=== {0}", total);




            ////ValueSwap, RefSwap
            //int num1 = 100;
            //int num2 = -100;

            //ValueSwap(num1, num2);
            //Console.WriteLine("num1 : {0} num2 : {1}", num1, num2);

            //RefSwap(ref num1, ref num2);
            //Console.WriteLine("num1 : {0} num2 : {1}", num1, num2);



            ////out, ref
            //int a;
            //int b;

            //InitNum(out a);
            //Console.WriteLine("a : " + a);

            //b = 0;  //무조건 초기화 필수!! 없으면 오류남
            //InitRefNum(ref b);  //out과 차이점 : b를 초기화하지 않고 사용 불가
            //Console.WriteLine("b : " + a);

        }


        ////method 1//
        //static void InitTilte()
        //{
        //    Console.WriteLine("짝수 & 홀수 보여주기 (0~100)");
        //}

        //static void PrintEven()
        //{
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        if(i%2==0)
        //        {
        //            Console.Write(" 짝수 : {0}", i);
        //        }
        //        if(i%10==0 && i !=0)
        //        {
        //            Console.WriteLine();
        //        }
        //    }
        //}

        //static void PrintOdd()
        //{
        //    for (int i = 0; i <= 100; i++)
        //    {
        //        if (i % 2 == 1)
        //        {
        //            Console.Write(" 홀수 : {0}", i);
        //        }
        //        if (i % 10 == 1 && i != 1)
        //        {
        //            Console.WriteLine();
        //        }
        //    }
        //}




        ////method 2//
        //static int Add()
        //{
        //    int a = 0;
        //    return ++a;
        //}

        //static int InputNum()
        //{
        //    Console.Write("입력하려는 정수를 넣어주세요");
        //    int num = int.Parse(Console.ReadLine());
        //    return num;
        //}




        ////method 3
        //static int Square(int i)
        //{
        //    int input = i;
        //    return input * input;
        //}




        ////method 4
        //static bool PrintDot(int x,int y)
        //{
        //    Console.WriteLine();
        //    if (x<=0 || y <=0)
        //    {
        //        return false;
        //    }
        //    for (int i = 0; i < x; i++)
        //    {
        //        Console.WriteLine();
        //        for (int j = 0; j < y; j++)
        //        {
        //            Console.Write("#");
        //        }
        //    }
        //    return true;
        //}

        //static int Total(int kor,int eng, int math)
        //{
        //    int total = 0;
        //    total = kor + eng + math;
        //    return total;
        //}




        ////ValueSwap,
        //static public void ValueSwap(int a, int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;

        //    Console.WriteLine("ValueSwap");
        //    Console.WriteLine("num1 : {0}   num2 : {1}", a, b);

        //}
        //static public void RefSwap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;

        //    Console.WriteLine("RefSwap");
        //    Console.WriteLine("num1 : {0}   num2 : {1}", a, b);

        //}




        ////out, ref
        //static void InitNum(out int addNum)
        //{
        //    addNum = 100;
        //}
        //static void InitRefNum(ref int refNum)
        //{
        //    refNum = 100;
        //}

    }
}
