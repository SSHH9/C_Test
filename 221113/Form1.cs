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

namespace _221113
{
    public partial class Form1 : Form
    {
        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 300;

        static void UpdateGO(int[] _arrIndexX, int[,] _map)
        {
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                int indexMaxX = i + 1;
                int temp = _map[indexMaxX, _arrIndexX[i]];
                _map[indexMaxX, _arrIndexX[i] + 1] = temp;
                _map[indexMaxX, _arrIndexX[i]] = 0;

                if (_arrIndexX[i] < 19)
                    _arrIndexX[i]++;
            }
        }


        static bool UpdateRandomGO(int[] _arrIndexX, int[,] _map, Random _rnd)
        {
            bool isFinish = false;
            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] >= 19)
                {
                    isFinish = true;
                    break;
                }
            }

            int rndIndex = _rnd.Next(0, 5); //0~4
            int indexY = _arrIndexX[rndIndex];

            int temp = _map[rndIndex + 1, indexY];
            _map[rndIndex + 1, indexY + 1] = temp;
            _map[rndIndex + 1, indexY] = 0;

            _arrIndexX[rndIndex]++;

            return isFinish;
        }


        static void UpdateView(char[] _tile, int[,] _map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);

                    if (j == MAP_Y - 1)
                        Console.WriteLine();
                }
            }
        }

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
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y]
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
                UpdateGO(arrIndexX, map);
                isFinish = UpdateRandomGO(arrIndexX, map, rnd);
                UpdateView(tile, map);

                if (isFinish)
                {
                    Console.WriteLine();

                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] >= 19)
                        {
                            Console.Write("Result => 1 : {0}", (i + 1));
                            break;
                        }
                    }
                    Console.Write("\nInput 0 for restart");
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
