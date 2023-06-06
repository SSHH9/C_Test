using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221023Assignment3
{
    public partial class Form1 : Form
    {
        static int InputNumber(int count)
        {
            int temp = 0;
            if (count == 0)
            {
                Console.Write("Input First Number ");
            }
            else
            {
                Console.Write("Input Second Number ");
            }

            temp = int.Parse(Console.ReadLine());
            return temp;
        }
        static void PrintResult(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static bool CheckEnd()
        {
            bool isEnd = false;
            int tmp = 0;

            Console.Write("Calculation Again? (1:OK, 0:NO, Up to 10 times) ");
            tmp = int.Parse(Console.ReadLine());
            isEnd = (tmp == 0);

            return isEnd;
        }
        public Form1()
        {
            InitializeComponent();

            int[] inputA = new int[10];
            int[] inputB = new int[10];
            int indexCount = 0;

            while (true)
            {
                inputA[indexCount] = InputNumber(0);
                inputB[indexCount] = InputNumber(1);

                PrintResult(inputA[indexCount], inputB[indexCount]);

                indexCount++;

                if (indexCount >= 10 || CheckEnd())
                {
                    for (int i = 0; i < indexCount; i++)
                    {
                        PrintResult(inputA[i], inputB[i]);
                    }
                    break;
                }
            }          

        }
    }
}

