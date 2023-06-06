using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _220925Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //int a = 100;
            //string b = "aaa";
            //float c = 0.123f;
            //char d = 'a';

            //Console.writeline("a : {0}, a.gettype() : {1}", a, a.gettype());
            //Console.writeline("b : {0}, b.gettype() : {1}", b, b.gettype());
            //Console.writeline("c : {0}, c.gettype() : {1}", c, c.gettype());
            //Console.writeline("d : {0}, d.gettype() : {1}", d, d.gettype());

            //////////////////////////////////////////////////

            Console.Write("Write score of Korean language ");
            string s1 = Console.ReadLine(); //int.Parse(Console.ReadLine());
            Console.Write("Write score of English ");
            string s2 = Console.ReadLine();
            Console.Write("Write score of Math ");
            string s3 = Console.ReadLine();
            Console.Write("Write score of Science ");
            string s4 = Console.ReadLine();

            double num1 = Convert.ToDouble(s1);
            double num2 = Convert.ToDouble(s2);
            double num3 = Convert.ToDouble(s3);
            double num4 = Convert.ToDouble(s4); 

            Console.WriteLine("Korean language : {0}, English : {1}, Math :{2}, Science : {3}" + "\n" + "Sum : {4}, Average : {5}", num1, num2, num3, num4, num1+num2+num3+num4, (num1 + num2 + num3 + num4)/4);

        }
    }
}
