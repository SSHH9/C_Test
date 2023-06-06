using System;

namespace _221218Assignment1
{
    class Student
    {
        private int id;
        private int kor;
        private int math;
        private int eng;

        public int ID {  get { return id; } }
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }

        public Student()
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


    }



    class Program
    {
        static void PrintID(Student[] arrStudents)
        {
            foreach (Student data in arrStudents)
            {
                data.PrintID();
            }

        }
        static int CheckID(int id, Student[] arrStudents)
        {
            for (int i = 0; i < arrStudents.Length; i++)
            {
                if (id == arrStudents[i].ID)
                {
                    return i;
                }
            }
            return -1;

        }
        static void Main(string[] args)
        {

            const int MAX = 3;
            int inputSel = 0;
            int selID = -1;

            Student[] arrStudents = new Student[MAX];


            for (int i = 0; i < MAX; i++)
            {
                arrStudents[i] = new Student();
                arrStudents[i].InputID();
                arrStudents[i].InputKor();
                arrStudents[i].InputMath();
                arrStudents[i].InputEng();

                Console.WriteLine();
            }

            Console.Clear();

            while (true)
            {
                PrintID(arrStudents);
                Console.Write("Input Student ID [(0):Exit]");

                inputSel = int.Parse(Console.ReadLine());

                if (inputSel == 0)
                {
                    break;
                }
                selID = CheckID(inputSel, arrStudents);

                if (selID >= 0)
                {
                    Console.WriteLine("Korean Score: {0}", arrStudents[selID].KOR);
                    Console.WriteLine("Math Score: {0}", arrStudents[selID].MATH);
                    Console.WriteLine("English Score: {0}", arrStudents[selID].ENG);

                    int total = arrStudents[selID].GetTotal();

                    //Console.WriteLine("Average: {0}", (kor[selID] + mat[selID] + eng[selID]) / 3f);
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
