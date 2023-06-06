using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221023Assignment2
{
    public partial class Form1 : Form
    {
        static void InputID(int[] ID, int index)
        {
            Console.Write("Input Student ID: ");
            ID[index] = int.Parse(Console.ReadLine());
        }
        static void InputKor(int[] kor, int index)
        {
            Console.Write("Input Korean Score: ");
            kor[index] = int.Parse(Console.ReadLine());
        }
        static void InputMath(int[] math, int index)
        {
            Console.Write("Input Math Score: ");
            math[index] = int.Parse(Console.ReadLine());
        }
        static void InputEng(int[] eng, int index)
        {
            Console.Write("Input English Score: ");
            eng[index] = int.Parse(Console.ReadLine());
        }
        static void PrintID(int max, int[] ID)  ///max??
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Student ID: {0} ", ID[i]);
            }            
        }
        static int CheckID(int id, int max, int[] ID)
        {
            int index = Array.IndexOf(ID, id);
            return index;
        }
        public Form1()
        {
            InitializeComponent();

            const int MAX = 3;

            int[] ID = new int[3];
            int[] kor = new int[3];
            int[] math = new int[3];
            int[] eng = new int[3];

            int inputSel = 0;
            int selID = -1;

            for (int i = 0; i < MAX; i++)
            {
                InputID(ID, i);
                InputKor(kor, i);
                InputMath(math, i);
                InputEng(eng, i);

                Console.WriteLine("\n");
            }

            while (true)
            {
                PrintID(MAX, ID);
                Console.Write("Input Student ID [(0):Exit]");

                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                {
                    break;
                }
                selID = CheckID(inputSel, MAX, ID);

                if (selID >= 0)
                {
                    Console.WriteLine("Korean Score: {0}", kor[selID]);
                    Console.WriteLine("Math Score: {0}", math[selID]);
                    Console.WriteLine("English Score: {0}", eng[selID]);
                    Console.WriteLine("Total: {0}", kor[selID] + math[selID] + eng[selID]);
                    Console.WriteLine("Average: {0}", (kor[selID] + math[selID] + eng[selID]) / 3f);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("{0} is NOT exist. Please input ID again.", inputSel);
                }
                
                
            } 
        }
    }
}
