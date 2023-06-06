using System;

namespace _230212Assignment7_277
{
    class Account
    {
        public string name;
        public float Money;
        public int count;
        public string accountNum;
        public int inputcount=0;

        public Account(string name, float Money)
        {
            this.name = name;
            this.Money = Money;

            Random rand = new Random();
            string a1 = rand.Next(100, 1000).ToString();
            string a2 = rand.Next(10, 100).ToString();
            string a3 = rand.Next(100000, 1000000).ToString();

            this.accountNum = a1 + "-" + a2 + "-" + a3;

            Console.WriteLine("Bank: SC Bank");
            Console.WriteLine("Account: {0}", accountNum);
        }

        public void get_account_num()
        {
            Console.WriteLine();
        }
        public void deposit(float deposit)
        {
            if (deposit >= 1)
            {
                Money += deposit;

                inputcount++;

                if (inputcount%5 == 0)
                {
                    Money = Money * 1.01f;
                }
            }
        }
        public void withdraw(float withdraw)
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
            Console.WriteLine("Balance: (0}", Money);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("python", 0);

            account.deposit(10000);
            account.deposit(10000);
            account.deposit(10000);
            account.deposit(5000);
            account.deposit(5000);

            Console.WriteLine(account.Money);
        }
    }
}
