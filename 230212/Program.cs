using System;

namespace _230212
{
    class Human
    {
        public string name;
        public int age;
        public string sex;
        public Human(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;

            Console.WriteLine("응애응애crying");
        }

        public void who()
        {
            Console.WriteLine("name: {0}",this.name);
            Console.WriteLine("age: {0}",this.age);
            Console.WriteLine("sex: {0}",this.sex);
        }

        public void setInfo(string name, int age, string sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human areum = new Human("Unknown", 0, "Unknown");

            areum.who();

            areum.setInfo("areum",25,"female");

            areum.who();

        }
    }
}
