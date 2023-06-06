using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221023Assignment1
{
    public partial class Form1 : Form
    {
        static void Start()
        {
            Console.WriteLine("Program - Method");
        }

        static void Input(ref int kor, ref int mat, ref int eng)
        {
            Console.Write("Input Korean score(int)");
            kor = int.Parse(Console.ReadLine());
            Console.Write("Input Math score(int)");
            mat = int.Parse(Console.ReadLine());
            Console.Write("Input English score(int)");
            eng = int.Parse(Console.ReadLine());
        }
        static int TotalSum(ref int kor, ref int mat, ref int eng)
        {
            int total = 0;
            total = kor + mat + eng;
            return total;
        }
        static void Average(int total, out float average)
        {
            average = total/3f;
        }

        public Form1()
        {
            InitializeComponent();

            int kor = 0;
            int eng = 0;
            int mat = 0;
            int total;
            float average;

            Start();
            Input(ref kor, ref mat, ref eng);
            total = TotalSum(ref kor, ref mat, ref eng);
            Average(total, out average);
            Console.WriteLine("kor: {0}, mat: {1}, eng:{2}",kor,mat,eng);
            Console.WriteLine("Total: {0}   Average:{1}", total, average);
        }
    }
}
