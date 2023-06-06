using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230409_delegateFunc
{
    delegate void delegateFunc();
    class MessageProcess
    {
        delegateFunc CallOkFunc;
        delegateFunc CallCancelFunc;
        
        public void Message(string msg, delegateFunc okFunc, delegateFunc cancelFunc)
        {
            CallOkFunc = okFunc;
            CallCancelFunc = cancelFunc;

            Console.WriteLine("Message: " + msg + " (0: ok, 1: cancel)");

            string inputStr = Console.ReadLine();

            if (inputStr.Equals("0"))
            {
                CallOkFunc();
            }
            else
            {
                CallCancelFunc();
            }
        }
    }
    internal class Program
    {
        static void CallOk()
        {
            Console.WriteLine("CallOk");
        }
        static void CallCancel()
        {
            Console.WriteLine("CallCancel");
        }
        static void Main(string[] args)
        {
            MessageProcess msg = new MessageProcess();
            
            //1) 이름 있는 함수 만들어서 파라미터에 넣어줌
            //msg.Message("Test Message", CallOk, CallCancel); //콜백함수: 함수의 파라미터가 함수인경우
            
            //2) 이름 없는 함수 delgate로 활용 - 활용도 높음
            msg.Message("Test Message",
                delegate ()
                {
                    Console.WriteLine("Call InDeligate");
                },
                CallCancel);
        }
    }
}
