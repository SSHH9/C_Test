using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace _221113_re
{
    public partial class Form1 : Form
    {
        const int MAP_X = 7;        //전체 행
        const int MAP_Y = 22;       //전체 열
        const int DELAY_TIME = 300; 

        /* 숫자 한칸씩 이동 */
        static void UpdateGO(int[] _arrIndexX, int[,] _map)
        {
            for (int i = 0; i < _arrIndexX.Length; i++)     //i=0               i=1                 i=2                 i=3                 i=4
            {
                int indexMaxX = i + 1;                      //1                 2                   3                   4                   5
                int temp = _map[indexMaxX, _arrIndexX[i]];  //temp=map[1,0]=3   temp=map[2,0]=4     temp=map[3,0]=5     temp=map[4,0]=6     temp=map[5,0]=7
                _map[indexMaxX, _arrIndexX[i] + 1] = temp;  //map[1,1]=3        map[2,1]=4          map[3,1]=5          map[4,1]=6          map[5,1]=7
                _map[indexMaxX, _arrIndexX[i]] = 0;         //map[1,0]=0        map[2,0]=0          map[3,0]=0          map[4,0]=0          map[5,0]=0

                if (_arrIndexX[i] < 19)                     //{0,0,0,0,0}       {1,0,0,0,0}         {1,1,0,0,0}         {1,1,1,0,0}         {1,1,1,1,0}
                    _arrIndexX[i]++;                        //{1,0,0,0,0}       {1,1,0,0,0}         {1,1,1,0,0}         {1,1,1,1,0}         {1,1,1,1,1}
            }               
        }                                                   

        /* 1~5 숫자 중 랜덤으로 선택하여 이동 */
        static bool UpdateRandomGO(int[] _arrIndexX, int[,] _map, Random _rnd)
        {
            bool isFinish = false;
            for (int i = 0; i < _arrIndexX.Length; i++)     //i=0 ~~~~~~~~~~~~ i=4
            {
                if (_arrIndexX[i] >= 19)                    //_arrIndex[i] 가 19보다 커지면 isFinish=true
                {
                    isFinish = true;
                    break;
                }
            }
                                                            
            int rndIndex = _rnd.Next(0, 5); //0~4 중 랜덤정수    만약 2 라면
            int indexY = _arrIndexX[rndIndex];                //indexY=_arrIndexX[2]=1

            int temp = _map[rndIndex + 1, indexY];            //temp=_map[3,1]=5
            _map[rndIndex + 1, indexY + 1] = temp;            //map[3,2]=5
            _map[rndIndex + 1, indexY] = 0;                   //map[3,1]=0

            _arrIndexX[rndIndex]++;                           //{1,1,2,1,1}

            return isFinish;                                  //false
        }

        /* 이동한 것처럼 보이게 화면을 새로 업데이트 */
        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)                 //i=0                                                               i=1
            {
                for (int j = 0; j < MAP_Y; j++)             //j=0                       1 ~~~~~~~~~~~~~~~~~ 21                  j=0             1               2 ~~~~~~~~~~~~~ 21
                {
                    int tileIndex = _map[i, j];             //tileIndex=_map[0,0]=1     [0,1]=1             [0,21]=1            [1,0]=0         [1,1]=3         [1,2]=0         [1,21]=0
                    Console.Write(_tile[tileIndex]);        //_tile[1]='-'              _tile[1]='-'        _tile[1]='-'        _tile[0]=' '    _tile[3]='1'    _tile[0]=' '    _tile[0]=' '

                    if (j == MAP_Y - 1)
                        Console.WriteLine();
                }
            }
        }

        /* DELAY_TIME 마다 화면 지우기 */
        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }


        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            //               0    1    2    3    4    5    6    7
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };   // 콘솔 창에서 쓰이는 모든 경우의 문자

            int[,] map = new int[MAP_X, MAP_Y]  // 콘솔 창에 보이는 전체 맵
            {
                //0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, //0
                { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //1
                { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //2
                { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //3
                { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //4
                { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //5
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, //6
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;

            while (true)
            {
                UpdateGO(arrIndexX, map);                           // 숫자가 한칸씩 이동하게 하는 메소드
                isFinish = UpdateRandomGO(arrIndexX, map, rnd);     // 1~5 숫자 중 하나의 숫자를 랜덤으로 이동하게 하는 메소드
                UpdateView(tile, map);                              // 이동할 때마다 새로 화면을 업데이트

                if (isFinish)                                       //arrIndexX[i] 가 19보다 커지면 isFinish=true
                {
                    Console.WriteLine();

                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("Result => 1st : {0}", (i + 1));  //승리한 숫자 출력
                            break;
                        }
                    }
                    Console.Write("\nInput 0 for restart ");
                    string inputSr = Console.ReadLine();

                    if (inputSr == "0")
                    {
                        arrIndexX = new int[] { 0, 0, 0, 0, 0 };
                        map = new int[MAP_X, MAP_Y]
                        {
                            //0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21
                            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, //0
                            { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //1
                            { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //2
                            { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //3
                            { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //4
                            { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //5
                            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, //6
                        };
                    }
                    else
                    {
                        Console.Write("\nExit");
                        break;
                    }
                }
                ClearView();
            }




            //Random rnd = new Random();

            //// Index         0    1    2    3    4    5    6    7 
            //char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            //int[,] map = new int[MAP_X, MAP_Y]
            //{
            //    //0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 
            //    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, //0
            //    { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //1
            //    { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //2
            //    { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //3
            //    { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //4
            //    { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //5
            //    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }  //6
            //};

            //int[] arrIndexX = { 0, 0, 0, 0, 0, 0 };
            //bool isFinish = false;

            //while (true)
            //{
            //    UpdateGO(arrIndexX, map);
            //    isFinish = UpdateRandomGO(arrIndexX, map, rnd);
            //    UpdateView(tile, map);

            //    if (isFinish)
            //    {
            //        Console.WriteLine();

            //        for (int i = 0; i < arrIndexX.Length; i++)
            //        {
            //            if (arrIndexX[i] >= 19)
            //            {
            //                Console.Write("Result => 1 : {0}", (i + 1));
            //                break;
            //            }
            //        }
            //        Console.Write("\nInput 0 for restart");
            //        string inputStr = Console.ReadLine();

            //        if (inputStr == "0")
            //        {
            //            arrIndexX = new int[] { 0, 0, 0, 0, 0 };
            //            map = new int[MAP_X, MAP_Y]
            //            {
            //                //0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21 
            //                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, //0
            //                { 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //1
            //                { 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //2
            //                { 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //3
            //                { 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //4
            //                { 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0 }, //5
            //                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }  //6
            //            };
            //        }
            //        else
            //        {
            //            Console.Write("\nExit");
            //            break;
            //        }
            //    }

            //    ClearView();
            //        }
            //    }
        }
    }
}
