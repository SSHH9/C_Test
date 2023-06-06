using System;

namespace _230212Assignment5_275
{
    class Account
    {
        public string name;
        public int Money;
        public int count;

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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Kim", 0);

            account.deposit(1000);
            account.withdraw(100);

            Console.WriteLine(account.Money);
        }
    }
}
