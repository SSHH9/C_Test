﻿using System;

namespace _230219Assignment
{
    /////281
    class car
    {
        public int wheel;
        public int price;
        /////286 추가
        public string driving;

        /////281~285
        public car(int wheel, int price)
        {
            this.wheel = wheel;
            this.price = price;
        }

        /////286 수정
        //public car(int wheel, int price, string driving)
        //{
        //    this.wheel = wheel;
        //    this.price = price;
        //    this.driving = driving;
        //}

        public void WHEEL()
        {
            Console.WriteLine(wheel);
        }
        public void PRICE()
        {
            Console.WriteLine(price);
        }
        public virtual void INFO()
        {
            Console.WriteLine("The number of WHEEL: {0}", wheel);
            Console.WriteLine("PRICE: {0}", price);
        }

    }

    /////282
    //class bicycle : car
    //{
    //    public int bike_wheel;
    //    public int bike_price;
    //    public bicycle(int wheel, int price) : base(wheel, price)
    //    {
    //        this.bike_wheel = wheel;
    //        this.bike_price = price;
    //    }
    //}

    ///////284
    class bicycle : car
    {
        public int bike_wheel;
        public int bike_price;
        public string bike_driving;
        public bicycle(int wheel, int price, string bike_driving) : base(wheel, price)
        {
            this.bike_wheel = wheel;
            this.bike_price = price;
            this.bike_driving = bike_driving;
        }
        public void DRIVING()
        {
            Console.WriteLine(this.bike_driving);
        }

        //287
        public override void INFO()
        {
            base.INFO();
            Console.WriteLine("DRIVING INFO: {0}", bike_driving);
        }
    }

    /////286 수정
    //class bicycle : car
    //{
    //    public int bike_wheel;
    //    public int bike_price;
    //    public string bike_driving;
    //    public bicycle(int wheel, int price, string driving) : base(wheel, price, driving)
    //    {
    //        this.bike_wheel = wheel;
    //        this.bike_price = price;
    //        this.bike_driving = driving;
    //    }
    //    public void DRIVING()
    //    {
    //        Console.WriteLine(this.bike_driving);
    //    }
    //}

    /////285
    class car2 : car
    {
        public car2(int wheel, int price) : base(wheel, price)
        {
            this.wheel = wheel;
            this.price = price;
        }
        public void INFO()
        {
            Console.WriteLine("The number of WHEEL: {0}", wheel);
            Console.WriteLine("PRICE: {0}", price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /////281
            //car car = new car(2, 1000);
            //Console.WriteLine(car.wheel);
            //Console.WriteLine(car.price);
            //car.WHEEL();
            //car.PRICE();

            /////283
            //bicycle bicycle = new bicycle(2, 100);
            //Console.WriteLine(bicycle.price);
            //bicycle.PRICE();

            /////284
            //bicycle bicycle = new bicycle(2, 100, "simano");
            //Console.WriteLine(bicycle.bike_driving);
            //bicycle.DRIVING();

            /////285
            //car2 car2 = new car2(4, 1000);
            //car2.INFO();

            /////286
            bicycle bicycle = new bicycle(2, 100, "simano");
            bicycle.INFO();


        }
    }
}
