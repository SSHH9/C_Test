using System;
using System.Collections;
using System.Collections.Generic;

namespace _230108Assignment1
{
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID { get { return id; } }
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }

        public CStudent()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public void InputID()
        {
            Console.Write("Input Student ID: ");
            this.id = int.Parse(Console.ReadLine());
        }
        public void InputKor()
        {
            Console.Write("Input Korean Score: ");
            this.kor = int.Parse(Console.ReadLine());
        }
        public void InputMath()
        {
            Console.Write("Input Math Score: ");
            this.math = int.Parse(Console.ReadLine());
        }
        public void InputEng()
        {
            Console.Write("Input English Score: ");
            this.eng = int.Parse(Console.ReadLine());
        }
        public void PrintID()
        {
            Console.WriteLine("Student ID: {0}", this.id);
        }

        public int GetTotal()
        {
            return kor + math + eng;
        }
        public int GetAvr()
        {
            return (kor + math + eng)/3;
        }
    }
    class Program
    {
        static void PrintID(Hashtable hashtable)
        {
            foreach (int key in hashtable.Keys)
            {
                CStudent student = (CStudent)hashtable[key];////////////////
                student.PrintID();
                //Console.WriteLine("Student ID: {0}", key);
                //key.PrintID();
            }
        }
        static int CheckID(int id, Hashtable hashtable)
        {
            if (hashtable.ContainsKey(id))
            {
                return id;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int inputSel = 0;
            int selID = -1;

            Hashtable hashtable = new Hashtable();

            while (true)
            {
                PrintID(hashtable);
                Console.Write(" == 성적 입력 중 == [(0):Exit]");

                if (Console.ReadLine() == "0")
                {
                    break;
                }
                CStudent student2 = new CStudent();
                student2.InputID();
                student2.InputKor();
                student2.InputMath();
                student2.InputEng();

                hashtable.Add(student2.ID, student2);
                Console.WriteLine();
            }
            
            Console.Clear();

            while (true)
            {
                PrintID(hashtable);
                Console.Write("Input Student ID ");

                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                {
                    break;
                }
                selID = CheckID(inputSel, hashtable);

                if (selID >= 0)
                {
                    CStudent student3 = (CStudent)hashtable[selID];////////////////

                    Console.WriteLine("Korean Score: {0}", student3.KOR);
                    Console.WriteLine("Math Score: {0}", student3.MATH);
                    Console.WriteLine("English Score: {0}", student3.ENG);

                    int total = student3.GetTotal();
                    float avr = student3.GetAvr();

                    Console.WriteLine("Total: {0}", total);
                    Console.WriteLine("Average: {0}", avr);
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("{0} is NOT exist. Please input ID again.", inputSel);
                }
            }

            //while (true)
            //{
            //    Console.Write(" == Input Score == [(0):Exit]");
            //    inputSel = int.Parse(Console.ReadLine());

            //    Console.Write("Input Student ID ");


            //    if (inputSel == 0)
            //    {
            //        Console.Clear();
            //        PrintID(hashtable);
            //        Console.Write("Input Student ID [(0):Exit]");
            //        inputSel = int.Parse(Console.ReadLine());
            //    }

            //    hashtable.Add(inputSel, 10);
            //}

            ////Console.Clear();

            //while (true)
            //{

            //}
        }
    }
}
