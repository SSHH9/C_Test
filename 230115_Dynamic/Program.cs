using System;

namespace _230115_Dynamic
{
    class Program
    {
        static T AddArray<T>(T[] arrDatas) //AddArray<T> : 일반화 함수라는 것을 표현
        {
            //T temp = 0; //이 경우 T의 형식이 정해지지 않았기 때문에 int 형식인 0으로 딱 설정해서 초기화 할 수 없음
            //object aaa = 0; //이런식으로 초기화 해 줘도 되지만 boxing, unboxing 발생하여 dynamic temp = default(T);로 초기화
            dynamic temp = default(T);  // 0(value타입) 또는 null(reference 타입)

            for (int i = 0; i < arrDatas.Length; i++)
            {
                temp += arrDatas[i];
            }
            return temp;
        }

        static T SumArray<T>(T[] arrDatas)
        {
            T temp = default(T);

            for (int i = 0; i < arrDatas.Length; i++)
            {
                //temp += arrDatas[i];          //이 경우 +=가 int 형식에서 사용되는 연산이기 때문에 사용불가
                temp += (dynamic)arrDatas[i];   //(dynamic) 추가 해 줘야 함
            }
            return temp;
        }
        static void PrintArray<T>(T[] arrDatas)
        {
            foreach (var data in arrDatas)
            {
                Console.WriteLine("data: {0}", data);
            }
        }
        static void Main(string[] args)
        {
            int[] arrNums = { 1, 2, 3, 4, 5 };
            //
            var a = 0;
            object b = 0;
            dynamic c = 0;
            //위 세개 차이 알아두기

            Console.WriteLine("AddArray: {0}",AddArray(arrNums));
            PrintArray(arrNums);
        }
    }
}
