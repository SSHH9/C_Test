using System;

namespace _221225Assignment
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I Fly!");
        }
        public void Run()
        {
            Console.WriteLine("I Run!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Fly();
            car.Run();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}
