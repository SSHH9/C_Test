using System;
using System.Collections.Generic;

namespace _230212_Class2
{
    class Stock
    {
        public string name;
        public string code;
        public float PER;
        public float PBR;
        public float profit;
        public Stock(string name, string code, float PER, float PBR, float profit)
        {
            this.name = name;
            this.code = code;
            this.PER = PER;
            this.PBR = PBR;
            this.profit = profit;
        }

        public void set_name(string name)
        {
            this.name = name;
        }
        public void set_code(string code)
        {
            this.code = code;
        }
        public void set_per(float PER)
        {
            this.PER = PER;
        }
        public void set_pbr(float PBR)
        {
            this.PBR = PBR;
        }
        public void set_dividend(float profit)
        {
            this.profit = profit;
        }


        public string get_name()
        {
            return this.name;
        }
        public string get_code()
        {
            return this.code;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Stock samsung = new Stock("samsung", "005930",15.79f,1.33f,2.83f);
            Stock hyundai = new Stock("hyundai", "005380", 8.70f, 0.35f, 4.27f);
            Stock lg = new Stock("lg", "066570", 317.34f, 0.69f,   1.37f);

            samsung.set_name("삼성전자");
            samsung.set_per(12.75f);

            //Console.WriteLine(samsung.PER);

            List<Stock> stocks = new List<Stock>() { };

            stocks.Add(samsung);
            stocks.Add(hyundai);
            stocks.Add(lg);

            foreach (var item in stocks)
            {
                Console.WriteLine(item.code);
                Console.WriteLine(item.PER);
            }
        }
    }
}
