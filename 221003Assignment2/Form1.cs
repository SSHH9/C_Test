using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221003Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] arr = { 0, 0, 0, 0, 0 };
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Write the score of student : ");
                int a = int.Parse(Console.ReadLine());
                arr[i] = a;
            }            

            Console.Write("Max : {0} ", arr.Max());
            Console.Write("Min : {0} ", arr.Min());

        }
    }
}
