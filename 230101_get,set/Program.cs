using System;

namespace _230101_get_set
{
    class AA
    {
        private int num;        // 정보은닉. num은 private으로 은닉하고 public int NUM으로 set

        public int NUM
        {
            get { return num; }
            set { num = value; }    //set부분을 구현하지 않으면 read 만 가능
        }

        ////보통 프로퍼티 만들 때 깔끔해보이게 이렇게 만듦//
        //public int NUM { get; set; } 

        public string NAME { get; set; } = "NoName";
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            //aa.NUM = 100;  //value

            Console.WriteLine("aa.NUM: {0}", aa.NUM);
            Console.WriteLine("aa.name: {0}", aa.NAME);

            aa.NUM = 100;
            Console.WriteLine("aa.NUM: {0}", aa.NUM);

            aa.NAME = "JACK";
            Console.WriteLine("aa.name: {0}", aa.NAME);
        }
    }
}
