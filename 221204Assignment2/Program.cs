using System;
using System.Collections.Generic;

namespace _221204Assignment2
{
    class Customer
    {
        public double customerID;
        public string customerName;   
        public string customerGrade;
        public double bonusPoint;
        public double bonusRatio;
        public double salesRatio;

        public Customer(int customerID, string customerName)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            this.customerGrade = "SILVER";
            this.bonusRatio = 0.01;
            this.salesRatio = 0;
        }

        public virtual void showCustomerInfo()
        {
            Console.WriteLine(customerName + " 님의 등급은 " + customerGrade + " 이며, 보너스 포인트는 " + bonusPoint + " 점 입니다.");
        }

        public virtual void setCustomer(int customerID, string customerName)
        {
            this.customerID = customerID;
            this.customerName = customerName;
        }

        public virtual double calcPrice(double price)
        {
            bonusPoint = bonusPoint + price * bonusRatio;
            
            return price;
        }

        public virtual string getCustomerName()
        {
            return customerName;
        }
    }

    class GoldCustomer : Customer
    {
        public GoldCustomer(int customerID, string customerName) : base(customerID, customerName)
        {
            this.customerGrade = "Gold";
            this.bonusRatio = 0.02;
            this.salesRatio = 0.1;

            //this.customerID = customerID;       //생략가능
            //this.customerName = customerName;   //생략가능
        }

        public override double calcPrice(double price)
        {
            bonusPoint = bonusPoint + price * bonusRatio;
            price = price - price * salesRatio;

            return price;
        }

        //public override string getCustomerName()    // 상속되어 있기 때문에 생략가능
        //{
        //    base.customerName = customerName;
        //    return customerName;
        //}
    }

    class VIPCustomer : Customer
    {
        int InfoNumber;

        public VIPCustomer(int customerID, string customerName, int InfoNumber) : base(customerID, customerName)
        {
            this.customerGrade = "VIP";
            this.bonusRatio = 0.05;
            this.salesRatio = 0.1;

            this.customerID = customerID;
            this.customerName = customerName;
            this.InfoNumber = InfoNumber;
        }

        public override void showCustomerInfo()
        {
            Console.WriteLine(customerName + " 님의 등급은 " + customerGrade + " 이며, 보너스 포인트는 " + bonusPoint + " 점 입니다. 담당 상담원 번호는 " + InfoNumber + " 입니다.");
        }

        public override double calcPrice(double price)
        {
            bonusPoint = bonusPoint + price * bonusRatio;
            price = price - price * salesRatio;

            return price;
        }

        //public override string getCustomerName()    // 상속되어 있기 때문에 생략가능
        //{
        //    base.customerName = customerName;
        //    return customerName;
        //}        
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customerList = new List<Customer>();
            
            Customer customerLee = new Customer(10010, "이순신");
            Customer customerShin = new Customer(10020, "신사임당");
            Customer customerHong = new GoldCustomer(10030, "홍길동");
            Customer customerYul = new GoldCustomer(10040, "이율곡");
            Customer customerKim = new VIPCustomer(10050, "김유신", 12345);

            customerList.Add(customerLee);
            customerList.Add(customerShin);
            customerList.Add(customerHong);
            customerList.Add(customerYul);
            customerList.Add(customerKim);

            Console.WriteLine("======= 고객 정보 출력 =======");

            foreach (Customer customer in customerList)
            {
                customer.showCustomerInfo();
            }

            Console.WriteLine("======= 할인율과 보너스 포인트 계산 =======");

            double price = 10000;
            foreach (Customer customer in customerList)
            {
                double cost = customer.calcPrice(price);
                Console.WriteLine(customer.getCustomerName() + " 님이 " + cost + " 원 지불하셨습니다."); ;
                Console.WriteLine(customer.getCustomerName() + " 님의 현재 보너스 포인트는" + customer.bonusPoint + " 점입니다." );
            }
        }
    }
}