using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    enum CHAR_STATE
    {
        IDLE,
        WALK,
        RUN,
        DIE
    }

    enum CLICK_STATE
    {
        NONE,
        CLICK = 100,
        DOUBLE_CLICK = 200,
        UP
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //char a = 'A';
            //int num = a;
            //Console.WriteLine("{0}, ASCII : {1}, cast : {2}", a, num, (char)num);

            ///////////////////////////////////////////////////////////

            //string str1 = "abcdefg";
            //string str2 = "hijklmn";
            //string str3 = str1 + str2;

            //Console.WriteLine("str1 + str2 : {0}", str3);

            //string str4 = "zzz";
            //string str5 = "zzz";
            //Console.WriteLine("str4 == str5 : {0}", (str4 == str5));

            //int x = 10;
            //string str6 = str5 + " " + ":" + x;
            //Console.WriteLine("str6 : {0}", str6);

            //string str7 = "Hello World!";
            //string str8 = str7.Replace("Hello", "Hi");
            //Console.WriteLine("str8 : {0}", str8);

            //Console.WriteLine("str8.ToUpper() : {0}", str8.ToUpper());
            //Console.WriteLine("str8.ToLower() : {0}", str8.ToLower());

            ///////////////////////////////////////////////////////////

            CHAR_STATE charState = CHAR_STATE.IDLE;
            Console.WriteLine("{0} {1}", charState, (int)charState);

            charState = CHAR_STATE.RUN;
            Console.WriteLine("{0} {1}", charState, (int)charState);

            charState = CHAR_STATE.DIE;
            Console.WriteLine("{0} {1}", charState, (int)charState);

            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.CLICK, (int)CLICK_STATE.CLICK);
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.DOUBLE_CLICK, (int)CLICK_STATE.DOUBLE_CLICK);
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.NONE, (int)CLICK_STATE.CLICK);
            Console.WriteLine("CLICK_STATE : {0} {1}", CLICK_STATE.UP, (int)CLICK_STATE.UP);

        }
    }
}
