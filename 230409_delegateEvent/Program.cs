using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230409_delegateEvent
{
    public delegate void delegateEvent(string msg);
    class InDelgate
    {
        public delegateEvent myDelegate;    //외부에서 접근가능
        public event delegateEvent myEvent; //그냥 delegate보다 안전성 있음(외부에서 접근불가능하기 떄문)

        //내부에서만 접근할 수 있으므로 따로 꼭 만들어주어야 함
        public void DoEvent(int a, int b)
        {
            if (null != myEvent)
                myEvent("DoEvent: " + (a + b));
        }
    }
    internal class Program
    {
        static public void ConsoleFunc(string msg)
        {
            Console.WriteLine("ConsoleFunc: " + msg);
        }

        static public void Main(string[] args) 
        {
            InDelgate id = new InDelgate();
            id.myEvent += new delegateEvent(ConsoleFunc);
            //id.myEvent += ConsoleFunc;  //윗줄이랑 기능 동일
            //id.myEvent = ConsoleFunc; 대입연산자 사용불가. +=, -=만 가능

            id.myDelegate = ConsoleFunc;

            id.myDelegate("Test");  //클래스 외부 직접 호출 가능
            //id.myEvent("Test");     //클래스 외부에서 직접 호출 불가

            for (int i = 0; i < 10; i++)
            {
                if (i==9)   //마지막줄 빼는 기능
                {
                    id.myEvent -= ConsoleFunc;  //이벤트를 뺏다 더했다 할 수 있음!!(그냥 delegate보다 효율적!)
                }
                id.DoEvent(i + 1, i + 2);
            }

        }
    }
}
