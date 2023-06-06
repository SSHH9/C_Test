using System;
using System.Collections.Generic;

namespace _230129Assignment7_194
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> data = new List<List<int>>() {
                new List<int> {2000, 3050, 2050, 1980},
                new List<int> {7500, 2050, 2050, 1980},
                new List<int> {15450, 15050, 15550, 14900},
            };

            List<List<double>> result = new List<List<double>>() { };

            for (int i = 0; i < 3; i++)
            {
                List<double> result1 = new List<double>() { };

                for (int j = 0; j < 4; j++)
                {
                    result1.Add(data[i][j] + data[i][j] * 0.00014);
                }
                result.Add(result1);
            }
            foreach (var result1 in result)
            {
                foreach (var item in result1)
                {
                    Console.WriteLine(item);
                }
            }

            //int i = 0;
            //List<List<double>> result = new List<List<double>>()
            //{
            //    new List<double> { data[i][i] + data[i][i] * 0.00014, data[i][i+1] + data[0][1] * 0.00014, data[i][i+2] + data[i][i+2] * 0.00014, data[i][i+3] + data[i][i+3] * 0.00014 },
            //    new List<double> { data[i+1][i] + data[i + 1][i] * 0.00014, data[i + 1][i + 1] + data[i + 1][i + 1] * 0.00014, data[i + 1][i + 2] + data[i + 1][i + 2] * 0.00014, data[i + 1][i + 3] + data[i + 1][i + 3] * 0.00014 },
            //    new List<double> { data[i+2][i] + data[i + 2][i] * 0.00014, data[i + 2][i + 1] + data[i + 2][i + 1] * 0.00014, data[i + 2][i + 2] + data[i + 2][i + 2] * 0.00014, data[i + 2][i + 3] + data[i + 2][i + 3] * 0.00014 },
            //};
            //foreach (var item in result)
            //{
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }
            //}
            //data
            //result[0].Add(data[0][0] + data[0][0] * 0.00014);

                //Console.WriteLine(data[0][0]);

                //result[0][0]=data[0][0] + data[0][0] * 0.00014;


                //foreach (var item in result[0])
                //{
                //    Console.WriteLine(item);
                //}


                //Console.WriteLine(data[0][0] + data[0][0] * 0.00014);


                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //        List<List<double>> result = new List<List<double>>();

                //        //result[i][j] = data[i][j] + data[i][j] * 0.00014;

                //        //result[0].Add(data[0][0] + data[0][0] * 0.00014);

                //        //result[0][0] = data[0][0] + data[0][0] * 0.00014;
                //        //result[0][1] = data[0][1] + data[0][1] * 0.00014;
                //        //result[0][2] = data[0][2] + data[0][2] * 0.00014;
                //        //result[0][3] = data[0][3] + data[0][3] * 0.00014;
                //        //result[1][0] = data[1][0] + data[1][0] * 0.00014;


                //        //result[0].Add(data[i][j] + data[i][j] * 0.00014);

                //        //result[0].Add(data[0][j] + data[0][j] * 0.00014);

                //        //Console.WriteLine(data[i][j] + data[i][j] *  0.00014);
                //        Console.WriteLine(data[0][0] + data[0][0] * 0.00014);

                //        //for (int k = 0; k < 4; k++)
                //        //{
                //        //result[k].Add(data[k][j] + data[k][j] * 0.00014);
                //        //Console.WriteLine(data[k][j] + data[k][j] * 0.00014);
                //        //}
                //        //foreach (var item in result[0])
                //        //{
                //        //    Console.WriteLine(item);
                //        //}
                //        //foreach (var item in result[0])
                //        //{
                //        //    Console.WriteLine(item);
                //        //}
                //    }
                //}
        }
    }
}
