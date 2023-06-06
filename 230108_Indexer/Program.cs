using System;
using System.Collections;
using System.Collections.Generic;

namespace _230108_Indexer
{
    class AA
    {
        ArrayList arrayList = new ArrayList();

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < arrayList.Count)
                {
                    return (string)arrayList[index];
                }
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < arrayList.Count)
                {
                    arrayList[index] = value;
                }
                else
                    arrayList.Add(value);
            }
        }

        public int count
        {
            get { return arrayList.Count; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();

            for (int i = 0; i < 10; i++)
            {
                aa[i] = string.Format("{0}", i);
            }
            aa[0] = "Hello";
            aa[1] = "World";

            for (int i = 0; i < aa.count; i++)
            {
                Console.WriteLine("aa: " + aa[i]);
            }
        }
    }


            /*
            class AA
            {
                private int[] num = new int[10];
                public int this[int index]
                {
                    get { return num[index]; }
                    set { num[index] = value; }
                }

            }
            class Program       //배열이나 콜렉션을 외부(다른 클래스)에서 접근하고 싶을때
            {
                static void Main(string[] args)
                {
                    AA aa = new AA();

                    for (int i = 0; i < 10; i++)
                    {
                        aa[i] = i;
                    }

                    aa[0] = 1000;
                    aa[1] = 100;

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("aa:[{0}]: {1}", i, aa[i]);
                    }

                }
            }
            */
        }
