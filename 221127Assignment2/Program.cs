using System;

namespace _221127Assignment2
{
    class Customer //silver
    {
        int customerID;
        string customerName;    //보통 private - set 함수에서만 접근할 수 있도록
        public string customerGrade;
        public double bonusPoint;
        public double bonusRatio;

        public Customer()
        {
            this.customerGrade = "SILVER";
            this.bonusRatio = 0.01;
        }

        public double calcPrice(int price)
        {
            bonusPoint = bonusPoint + price * bonusRatio;

            return price;  //return bonusPoint 가능
        }

        public void showCustomerInfo()
        {
            Console.WriteLine(customerName + " 님의 등급은 " + customerGrade+" 이며, 보너스 포인트는 "+ bonusPoint + " 점 입니다.");
        }

        public void setCustomerID(int customerID) //set - 값을 변경할때 체크하기 위한 함수 (직접적으로 바꾸지 않고 함수를 통해서 변경해줌), get - 값을 가져옴
        {
            this.customerID = customerID;
        }

        public void setCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

    }

    class VIPCustomer : Customer //VIP
    {
        double salesRatio;

        public VIPCustomer()
        {
            this.customerGrade = "VIP";    
            this.bonusRatio = 0.05;        
            this.salesRatio = 0.1;        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer Lee = new Customer();
            VIPCustomer Kim = new VIPCustomer();

            Lee.setCustomerName("이순신");
            Lee.setCustomerID(10010);
            Lee.bonusPoint = 1000;
            Lee.showCustomerInfo();

            Kim.setCustomerName("김유신");
            Kim.setCustomerID(10020);
            Kim.bonusPoint = 10000;
            Kim.showCustomerInfo();
        }
    }
}
