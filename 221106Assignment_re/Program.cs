using System;

namespace _221106Assignment_re
{
    class People
    {
        public int height;
        public int weight;
        public string name;
        public string gender;
        public int age;

        public People(int height, int weight, string name, string gender, int age)
        {
            this.height = height;
            this.weight = weight;
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine("키가 {0} 이고 몸무게가 {1} 킬로인 {2}이 있습니다. 이름은 {3} 이고 나이는 {4}세입니다.", height,weight,gender,name,age);
        }
    }

    class Order
    {
        private double number; //public보다는 private 사용하는 것이 외부의 무분별한 접근을 막아줌
        private string phone;
        private string address;
        private double date;
        private double time;
        private int price;
        private string menu;

        public Order(double number, string phone, string address, double date, double time, int price, string menu)
        {
            this.number = number;
            this.phone = phone;
            this.address = address;
            this.date = date;
            this.time = time;
            this.price = price;
            this.menu = menu;
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("아래와 같은 주문이 들어왔습니다.");
            Console.WriteLine("number: {0}", number);
            Console.WriteLine("phone: {0}", phone);
            Console.WriteLine("adress: {0}", address);
            Console.WriteLine("date: {0}", date);
            Console.WriteLine("time: {0}", time);
            Console.WriteLine("price: {0}", price);
            Console.WriteLine("menu: {0}", menu);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People Tomas = new People(180,78,"남성","Tomas",37);
            Tomas.Print();

            Order A = new Order(202011020003, "01023450001", "서울시 강남구 역삼동 111-333", 20201102, 130258, 35000, "0003");
            A.Print();
        }
    }
}
