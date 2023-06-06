using System;

namespace _230212Assignment6_276
{
    class Account
    {
        public string name;
        public int Money;
        public int count;
        public string accountNum;

        public Account(string name, int Money)
        {
            this.name = name;
            this.Money = Money;

            Random rand = new Random();
            string a1 = rand.Next(100, 1000).ToString();
            string a2 = rand.Next(10, 100).ToString();
            string a3 = rand.Next(100000, 1000000).ToString();

            this.accountNum = a1 + "-" + a2 +"-" + a3;

            Console.WriteLine("Bank: SC Bank");
            Console.WriteLine("Account: {0}", accountNum);
        }

        public void get_account_num()
        {
            Console.WriteLine();
        }
        public void deposit(int deposit)
        {
            if (deposit >= 1)
            {
                Money += deposit;


            }
        }
        public void withdraw(int withdraw)
        {
            if (Money > withdraw)
            {
                Money -= withdraw;
            }

        }
        public void display_info()
        {
            Console.WriteLine("Bank: SC Bank");
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Account: {0}", accountNum);
            Console.WriteLine("Balance: {0}", Money);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("python", 0);

            account.deposit(1000);
            account.withdraw(100);

            account.display_info();
        }
    }
}
