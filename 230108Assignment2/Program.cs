using System;
using System.Collections;
using System.Collections.Generic;

namespace _230108Assignment2
{
    class CSaveNumber
    {
        //private int[] saveNumbers = new int[10];
        //public int this[int index]
        //{
        //    get { return saveNumbers[index]; }
        //    set { saveNumbers[index] = value; }
        //}

        private int number1 { get; set; }
        private int number2 { get; set; }

        public CSaveNumber()
        {
            number1 = 0;
            number2 = 0;
        }

        public void InputNumber(int count)
        {
            if (count == 0)
            {
                Console.Write("Input First Number ");
                number1 = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Input Second Number ");
                number2 = int.Parse(Console.ReadLine());
            }
        }

        public void PrintResult()
        {
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        }
    }

    class Program 
    {
        static bool CheckEnd(int index)
        {
            bool isEnd = false;
            int tmp = 0;

            Console.Write("{0}번째 Calculation Again? (1:OK, 0:NO, Up to 10 times) ", index + 1);
            tmp = int.Parse(Console.ReadLine());
            isEnd = (tmp == 0);

            return isEnd;
        }
        static void Main(string[] args)
        {
            //int indexCount = 0; //몇번 돌았는지 확인
            ArrayList saveNumbers = new ArrayList();

            while (true)
            {
                CSaveNumber saveNumber2 = new CSaveNumber();
                
                saveNumber2.InputNumber(0);
                saveNumber2.InputNumber(1);

                saveNumber2.PrintResult();

                saveNumbers.Add(saveNumber2);

                if (CheckEnd(saveNumbers.Count))
                {
                    foreach (CSaveNumber item in saveNumbers)
                    {
                        item.PrintResult();
                    }
                    break;
                }
            }
        }
    }



    //class CSaveNumber
    //{
    //    private int[] saveNumbers = new int[10];
    //    public int this[int index]
    //    {
    //        get { return saveNumbers[index]; }
    //        set { saveNumbers[index] = value; }
    //    }

    //    private int number1 { get; set; }
    //    private int number2 { get; set; }

    //    public CSaveNumber()
    //    {
    //        number1 = 0;
    //        number2 = 0;
    //    }

    //    public void InputNumber(int count)
    //    {
    //        if (count == 0)
    //        {
    //            Console.Write("Input First Number ");
    //            number1 = int.Parse(Console.ReadLine());
    //        }
    //        else
    //        {
    //            Console.Write("Input Second Number ");
    //            number2 = int.Parse(Console.ReadLine());
    //        }
    //    }

    //    public void PrintResult()
    //    {
    //        Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
    //    }
    //    //static bool CheckEnd()
    //    //{

    //    //}
    //}
    //class Program
    //{
    //    static bool CheckEnd(int index)
    //    {
    //        bool isEnd = false;
    //        int tmp = 0;

    //        Console.Write("{0}번째 Calculation Again? (1:OK, 0:NO, Up to 10 times) ", index + 1);
    //        tmp = int.Parse(Console.ReadLine());
    //        isEnd = (tmp == 0);

    //        return isEnd;
    //    }
    //    static void Main(string[] args)
    //    {
    //        //CSaveNumber result = new CSaveNumber();
    //        //result[index]

    //        int index = 0; //몇번 돌았는지 확인
    //        ArrayList saveNumbers = new ArrayList();

    //        while (true)
    //        {
    //            saveNumbers[index] = 

    //            Console.WriteLine("{0}", saveNumbers[index]);

    //            //saveNumbers[indexCount] = new CSaveNumber();
    //            //saveNumbers[indexCount].InputNumber(0);
    //            //saveNumbers[indexCount].InputNumber(1);

    //            //saveNumbers[indexCount].PrintResult();

    //            //indexCount++;

    //            //if (indexCount >= 10 || CheckEnd(indexCount))
    //            //{
    //            //    for (int i = 0; i < indexCount; i++)
    //            //    {
    //            //        saveNumbers[i].PrintResult();
    //            //    }
    //            //    break;
    //            //}
    //        }
    //    }
    //    //static bool CheckEnd(int index)
    //    //{
    //    //    bool isEnd = false;
    //    //    int tmp = 0;

    //    //    Console.Write("{0}번째 Calculation Again? (1:OK, 0:NO, Up to 10 times) ", index + 1);
    //    //    tmp = int.Parse(Console.ReadLine());
    //    //    isEnd = (tmp == 0);

    //    //    return isEnd;
    //    //}
    //    //static void Main(string[] args)
    //    //{
    //    //    ArrayList saveNumbers = new ArrayList();

    //    //    while (true)
    //    //    {
    //    //        int index = 0;
    //    //        saveNumbers[index].InputNumber(index);
    //    //    }
    //    //}
    //}
}
