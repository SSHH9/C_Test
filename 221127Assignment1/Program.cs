using System;

namespace _221127Assignment1
{
    class Bus
    {
        int busNumber;
        int passengerCount;
        int money=0;

        public Bus(int busNumber)
        {
            this.busNumber = busNumber;
            
        }

        /* 버스 수입과 승객수 계산 */
        public void take(int money)
        {
            this.money += money;
            this.passengerCount++;
        }

        public void showBusInfo()
        {
            Console.WriteLine(busNumber + " 번 버스의 승객은 " + passengerCount + " 명이고, 수입은 " + money + " 원 입니다.");
        }
    }

    class Subway
    {
        int lineNumber;
        int passengerCount;
        int money=0;

        public Subway(int lineNumber)
        {
            this.lineNumber = lineNumber;
        }

        /* 지하철 수입과 승객수 계산 */
        public void take(int money)
        {
            this.money += money;
            this.passengerCount++;
        }

        public void showSubwayInfo()
        {
            Console.WriteLine(lineNumber + " 번 지하철의 승객은 " + passengerCount + " 명이고, 수입은 " + money + " 원 입니다.");
        }

    }

    class Student
    {
        string studentName;
        //int grade;
        int money;

        public Student(string studentName, int money)
        {
            this.studentName = studentName;
            this.money = money;
        }

        /* 버스비 지불 */
        public void takeBus(Bus bus)
        {
            bus.take(1000);
            money -= 1000;
        }

        /* 지하철비 지불 */
        public void takeSubway(Subway subway)
        {
            subway.take(1200);
            money -= 1200;
        }

        public void showStudentInfo()
        {
            Console.WriteLine(studentName + " 님의 남은 돈은 " + money + " 원 입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student J = new Student("James", 5000);
            Student T = new Student("Tomas", 10000);

            Bus bus = new Bus(100);
            Subway subway = new Subway(2);

            J.takeBus(bus);
            J.showStudentInfo();
            T.takeSubway(subway);
            T.showStudentInfo();

            bus.showBusInfo();
            subway.showSubwayInfo();
        }
    }
}
