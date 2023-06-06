using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221003
{
    enum DAY_OF_WEEK
    {
        SUN,
        MON,
        TUE,
        WED,
        THU,
        FRI,
        SAT,
    }

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


            //// 삼항 연산자
            //int num = 0;
            //bool result;

            //result = (num == 0) ? true : false;
            //Console.WriteLine("num : {0}", num);
            //Console.WriteLine("result : {0}", result);

            //result = (num > 10) ? true : false;
            //Console.WriteLine("result : {0}", result);


            //// null 병합 연산자
            //int? a = null;
            //int b = 10;
            //int? c = null;
            //int d = 100;
            //int result;

            //result = a ?? b;    // a가 null이면 b값을 result에 삽입
            //Console.WriteLine("result : " +result);

            //result = a ?? c ?? d;
            //Console.WriteLine("result : " + result);


            //// if ~ else //
            //bool isBool = false;
            //if (isBool) //기본값은 True
            //{
            //    Console.WriteLine("isBoolt : {0}", isBool);
            //}
            //else
            //{
            //    Console.WriteLine("isBoolf : {0}", isBool);
            //}

            //// if, else if , else //
            //Console.Write("write int");
            //string strNum = Console.ReadLine();
            //int a = int.Parse(strNum);

            //bool isA = false;
            //bool isB = true;
            //bool isC = true;
            //bool isD = false;

            //if(isA && isB)
            //{
            //    Console.WriteLine("1. false");
            //}
            //if (isB && isC)
            //{
            //    Console.WriteLine("2. true");
            //}
            //if (isC && isD)
            //{
            //    Console.WriteLine("3. true");
            //}
            //if (2>1 && 3<4 || 1>2)
            //{
            //    Console.WriteLine("4. true");
            //}

            //// switch //
            //int num = 0;
            //string strGrade = null;

            //Console.Write("write score");
            //num = int.Parse(Console.ReadLine());

            //switch (num/10)
            //{
            //    case 10:
            //    case 9:
            //        strGrade = "A"; //case10,9일때 모두 A
            //        break;
            //    case 8:
            //        strGrade = "B";
            //        break;
            //    case 7:
            //        strGrade = "C";
            //        break;
            //    case 6:
            //        strGrade = "D";
            //        break;
            //    default:    // else 같은 기능
            //        strGrade = "F";
            //        break;
            //}

            //Console.Write("result = {0}", strGrade);

            //DAY_OF_WEEK dayOfWeek = DAY_OF_WEEK.FRI;
            //string dayString = "";

            //switch (dayOfWeek)
            //{
            //    case DAY_OF_WEEK.SUN:
            //        dayString = "Sunday";
            //        break;
            //    case DAY_OF_WEEK.TUE:
            //        dayString = "Tuesday";
            //        break;
            //    case DAY_OF_WEEK.WED:
            //        dayString = "Wendesday";
            //        break;
            //    case DAY_OF_WEEK.THU:
            //        dayString = "Thursday";
            //        break;
            //    case DAY_OF_WEEK.FRI:
            //        dayString = "Friday";
            //        break;
            //    case DAY_OF_WEEK.SAT:
            //        dayString = "Saturday";
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine("Today is {0}", );

            //// do while //
            //int a = 0;
            //int num;
            //int total = 0;

            //Console.Write("0부터 몇까지 더할까요?");
            //num = int.Parse(Console.ReadLine());

            //do
            //{
            //    total = total + a++;    //a : 0 ~
            //} while (a <= num);

            //Console.WriteLine("total : {0}", total);

            ////for문 //
            //int total = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine("total : {0}", total);

        }
    }
}
