using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220925
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //// nullable //
            //double? a = 3.14;
            //char? b = 'a';

            //int num = 10;
            //int? c = num;

            //bool? isFlag = null;

            //Console.WriteLine("isFlag HasValue : {0}", isFlag.HasValue);

            //if (isFlag.HasValue)
            //{
            //    Console.WriteLine("isFlag HasValue : {0}", isFlag.Value);
            //}


            //// var //
            //var a = 100;
            //var b = 3.1452946;
            //var c = 3.56128655m;
            //Console.WriteLine(c.GetType());

            //var num = 0;
            //num = 100;


            //// const //
            //const int MAX = 100;
            //const int MIN = 0;

            //Console.WriteLine("MIN : {0} ~ MAX : {1}", MIN, MAX);

            ////MAX = 1000; impossible


            ////convert Type //
            //int a = 100;
            //float b = 3.2549684f;
            //decimal c = 1.956513m;

            //string strA = a.ToString();
            //string strB = b.ToString();
            //string strC = c.ToString();

            //Console.WriteLine("a.ToString() : {0}", strA);
            //Console.WriteLine("b.ToString() : {0}", strB);
            //Console.WriteLine("c.ToString() : {0}", strC);

            //int parseA = int.Parse(strA);
            //float parseB = float.Parse(strB);
            //decimal parseC = decimal.Parse(strC);

            //int convertA = Convert.ToInt32(strA);
            //float convertB = Convert.ToSingle(strB);
            //decimal converC = Convert.ToDecimal(strC);

            //int num = 100;
            //double dNum = (double)num;


            ////Value & Reference
            //int num = 100;
            //int refNum = num;
            //refNum = 1000;

            //Console.WriteLine("refStr : {0}, str : {1}", refNum, num);
            //Console.WriteLine("refStr : {0}, ReferenceEquals : {1}", refNum, object.ReferenceEquals(num,refNum));

            //int[] arrNum = { 100, 200 };
            //int[] refArrNum = arrNum;
            //refArrNum[0] = 1000;

            //Console.WriteLine("refStr : {0}, ReferenceEquals: {1}", arrNum[0], object.ReferenceEquals(arrNum,refArrNum));


            //// boxing //
            //int i = 123;
            //object o = i; //boxing
            //int j = (int)o; //unboxing
            //i = 456;

            //Console.WriteLine("i : {0}, o : {1}, j : {2}", i, o, j);
            //Console.WriteLine("ReferenceEquals : {0}", Object.ReferenceEquals(i, o));


            //// Console.ReadLine //
            //Console.WriteLine("Write first int");
            //string str1 = Console.ReadLine();
            //Console.WriteLine("Write second int");
            //string str2 = Console.ReadLine();

            //int num1 = int.Parse(str1);
            //int num2 = int.Parse(str2);

            //int sum = num1 + num2;

            //Console.WriteLine("{0} + {1} = {2}", num1, num2, sum);


            //// Calculate //
            //int a = 18;
            //int b = 6;
            //int c = a + b;
            //Console.WriteLine("c : " + c);

            //int d = a / b;
            //Console.WriteLine("d : " + d);

            //int e = a * (b + c);
            //Console.WriteLine("e : " + e);


            ////
            //int num = 10;
            //Console.WriteLine("num : {0}", num++); //코드 실행하고 +1
            //Console.WriteLine("num : {0}", num);   
            //Console.WriteLine("num : {0}", ++num); //+1하고 코드실행

            //Console.WriteLine("num : {0}", num--); //코드 실행하고 -1
            //Console.WriteLine("num : {0}", num);
            //Console.WriteLine("num : {0}", --num); //-1하고 코드실행






        }
    }
}
