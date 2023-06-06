using System;

namespace _220219Assignment2
{
    /////289
    class Parent
    {
        public virtual void Call()
        {
            Console.WriteLine("Call Parent");
        }
    }
    class Child:Parent
    {
        public override void Call()
        {
            Console.WriteLine("Call Child");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child me = new Child();
            me.Call();      //예상: Call Child
        }
    }
}
