﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221003Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            int countAns = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("{0}: What is Sum of two number? (Total 5 Question) ",i);
                Random rnd = new Random();
                int a = rnd.Next(0, 100);
                int b = rnd.Next(0, 100);

                Console.WriteLine("{0} + {1} = ??", a, b);

                int c = int.Parse(Console.ReadLine());

                if (c == a + b)
                {
                    Console.WriteLine("== Correct ==");
                    countAns += 1;
                }
                else
                {
                    Console.WriteLine("Wrong (The answer is {0})",a+b);
                }
            }

            Console.WriteLine("The number of Answer is {0}", countAns);

            

        }
    }
}
