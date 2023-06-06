using System;

namespace _230212Assignment1_271
{
    class Account
    {
        public string name;
        public int Money;

        public Account(string name, int Money)
        {
            this.name = name;
            this.Money = Money;

            Random rand = new Random();
            string a1 = rand.Next(100, 1000).ToString();
            string a2 = rand.Next(10, 100).ToString();
            string a3 = rand.Next(100000, 1000000).ToString();

            string accountNum = a1 + "-" + a2 + "-" + a3;

            Console.WriteLine("Bank: SC Bank");
            Console.WriteLine("Account: {0}", accountNum);
        }
        class Program
        {
            static void Main(string[] args)
            {
                Account account = new Account("Kim", 0);
            }
        }
    }
}
