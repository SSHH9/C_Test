using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221106Assignment
{
    class People
    {
        public int height = 180;
        public int weight = 78;
        //public string name = "Tomas";
        public int age = 37;

        public void Print()
        {
            Console.WriteLine("height: {0}", height);
            Console.WriteLine("weight: {0}", weight);
            Console.WriteLine("age: {0}", age);

        }
    }

    class Order
    {
        public double number = 202011020003;
        public string phone = "01023450001";
        public string adress = "서울시 강남구 역삼동 111-333";
        public double date = 20201102;
        public double time = 130258;
        public int price = 35000;
        public string menu = "0003";

        public void Print()
        {
            Console.WriteLine("number: {0}", number);
            Console.WriteLine("phone: {0}", phone);
            Console.WriteLine("adress: {0}", adress);
            Console.WriteLine("date: {0}", date);
            Console.WriteLine("time: {0}", time);
            Console.WriteLine("price: {0}", price);
            Console.WriteLine("menu: {0}", menu);
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            People Tomas = new People();
            Tomas.Print();

            Order A = new Order();
            A.Print();
        }
    }
}
