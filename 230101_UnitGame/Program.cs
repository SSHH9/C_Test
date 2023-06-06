using System;

namespace _230101_UnitGame
{
    class Army
    {
        protected int _HP;
        protected int _MP;
        protected int _Speed;
        protected int _Attack;

        public virtual void Run()
        {
            Console.WriteLine("{0}의 속도로 ", _Speed);
        }
        public virtual void Attack()
        {
            Console.WriteLine();

            if (this is Healer)
            {
                Console.Write("[마법 공격력 - {0}]으로 ", _Attack * _MP);
            }
            else
            {
                Console.Write("[공격력 - {0}]으로 ", _Attack);
            }
        }

    }

    class Barbarian : Army
    {
        public Barbarian()
        {
            _HP = 100;
            _MP = 0;
            _Speed = 100;
            _Attack = 100;
        }
        //////////////
        //Run Override - 100의 속도로 Barbarian 달려갑니다.
        public override void Run()
        {
            base.Run();     // 100의 속도로
            Console.WriteLine("Barbarian 달려갑니다.");
        }

        //Attack Override - 100의 공격력으로 Barbarian이 칼로 공격!!!
        public override void Attack()
        {
            base.Attack();     // 100의 공격력으로
            Console.WriteLine("Barbarian 칼로 공격!!!");
        }
    }
    class Giant : Army
    {
        public Giant()
        {
            _HP = 200;
            _MP = 0;
            _Speed = 10;
            _Attack = 200;
        }
        //////////////
        //Run Override - 10의 속도로 Giant 달려갑니다.
        public override void Run()
        {
            base.Run();     // 10의 속도로
            Console.WriteLine("Giant 달려갑니다.");
        }
        //Attack Override - 200의 공격력으로 Giant 칼로 공격!!!
        public override void Attack()
        {
            base.Attack();
            Console.WriteLine("Giant 칼로 공격!!!");
        }
    }
    class Healer : Army
    {
        public Healer()
        {
            _HP = 50;
            _MP = 100;
            _Speed = 200;
            _Attack = 10;
        }
        //////////////
        //Run Override - 200의 속도로 Healer 날아갑니다.
        public override void Run()
        {
            base.Run();     // 200의 속도로
            Console.WriteLine("Healer 날아갑니다.");
        }
        //Attack Override - ?의 마법 공격력으로 Healer 마법 공격!!!
        public override void Attack()
        {
            base.Attack();     // 100의 마법 공격력으로
            Console.WriteLine("Healer 마법공격!!!");
        }
    }

    class UnitControl
    {
        public enum UNIT
        {
            NONE,
            BARBARIAN,
            GIANT,
            HEALER,
        }

        const int MAX = 10;
        Army[] _ArrArmys;
        int indexCount;

        public UnitControl()
        {
            _ArrArmys = new Army[MAX];
            indexCount = 0;
        }

        public string Menu()
        {
            Console.WriteLine(" == Unit System == ");
            Console.WriteLine(" (1)Create   (2)Run  (3)Attack   (0은 exit)");

            return Console.ReadLine();
        }

        public void CreateUnit()
        {
            Console.WriteLine(" == 유닛 생성 == ");
            Console.WriteLine(" (1)Barbarian   (2)Giant  (3)Healer   (0은 Back)");

            UNIT typeUnit = UNIT.NONE;
            string strInput = Console.ReadLine();

            if (indexCount >= MAX)
            {
                Console.WriteLine(" == 유닛 생성 불가 == (총 유닛 : {0}", indexCount);
                Console.WriteLine();
                return;     //함수 나가기
            }

            if (strInput.Equals("1") || strInput.Equals("2") || strInput.Equals("3"))
            {
                typeUnit = (UNIT)int.Parse(strInput);
            }

            //////////////
            switch (typeUnit)   //case별로 유닛 생성 (_ArrArmys[indexCount], NONE일때는 _ArrArmys[indexCount] 넣어주면 안됨, indexCount--)
            {
                case UNIT.NONE:
                    indexCount--;
                    break;
                case UNIT.BARBARIAN:
                    _ArrArmys[indexCount] = new Barbarian();
                    break;
                case UNIT.GIANT:
                    _ArrArmys[indexCount] = new Giant();
                    break;
                case UNIT.HEALER:
                    _ArrArmys[indexCount] = new Healer();
                    break;
                default:
                    break;
            }
            indexCount++;

            Console.WriteLine(" == Creating Unit Finish == ( 총 유닛 : {0})", indexCount);
            Console.WriteLine();
        }

        public void UnitRunMenu()
        {
            Console.WriteLine(" == Unit Running == ");
            Console.WriteLine(" (1)Barbarian   (2)Giant  (3)Healer    (4)All Running   (0은 Back)");

            UNIT typeUnit = UNIT.NONE;
            string strInput = Console.ReadLine();

            if (strInput.Equals("1") || strInput.Equals("2") || strInput.Equals("3"))
            {
                typeUnit = (UNIT)int.Parse(strInput);
                UnitRun(typeUnit);
            }
            else if (strInput.Equals("4"))
            {
                UnitRun();
            }
            else
                Console.Clear();
        }
        public void UnitRun()
        {
            for (int i = 0; i < indexCount; i++)
            {
                _ArrArmys[i].Run();     //전체가 다 (10개가) 섞여서 달려갑니다 출력
            }
        }
        public void UnitRun(UNIT typeUnit)//////////////
        {
            //switch문으로 typeUnit 체크해서 배열 안에 유닛이 있는만큼 Run 실행     ex) 바바리안 두명이면 "바바리안 달려갑니다" 두 번 출력
            switch (typeUnit)
            {
                case UNIT.BARBARIAN:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (_ArrArmys[i] is Barbarian)
                        {
                            _ArrArmys[i].Run();     
                        }                        
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (_ArrArmys[i] is Giant)
                        {
                            _ArrArmys[i].Run();
                        }
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (_ArrArmys[i] is Healer)
                        {
                            _ArrArmys[i].Run();
                        }
                    }
                    break;
            }
        }
        public void UnitAttackMenu()//////////////
        {
            Console.WriteLine(" == 유닛 공격하기 == ");
            Console.WriteLine(" (1)Barbarian   (2)Giant  (3)Healer    (4)All Attack   (0은 Back)");

            UNIT typeUnit = UNIT.NONE;
            string strInput = Console.ReadLine();

            if (strInput.Equals("1") || strInput.Equals("2") || strInput.Equals("3"))
            {
                typeUnit = (UNIT)int.Parse(strInput);
                UnitAttack(typeUnit);
            }
            else if (strInput.Equals("4"))
            {
                UnitAttack();
            }
            else
                Console.Clear();
        }
        public void UnitAttack()//////////////
        {
            for (int i = 0; i < indexCount; i++)
            {
                _ArrArmys[i].Attack();     //전체가 다 (10개가) 섞여서 달려갑니다 출력
            }
        }
        public void UnitAttack(UNIT typeUnit)//////////////
        {
            //switch문으로 typeUnit 체크해서 배열 안에 유닛이 있는만큼 Run 실행     ex) 바바리안 두명이면 "바바리안 달려갑니다" 두 번 출력\ switch (typeUnit)
            switch (typeUnit)
            {
                case UNIT.BARBARIAN:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (_ArrArmys[i] is Barbarian)
                        {
                            _ArrArmys[i].Attack();
                        }
                    }
                    break;
                case UNIT.GIANT:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (_ArrArmys[i] is Giant)
                        {
                            _ArrArmys[i].Attack();
                        }
                    }
                    break;
                case UNIT.HEALER:
                    for (int i = 0; i < indexCount; i++)
                    {
                        if (_ArrArmys[i] is Healer)
                        {
                            _ArrArmys[i].Attack();
                        }
                    }
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UnitControl control = new UnitControl();
            string choice;  //메뉴 초이스
            bool isLoop = true;

            while (isLoop)
            {
                choice = control.Menu();    //메뉴화면 출력   return Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        control.CreateUnit();
                        break;
                    case "2":
                        control.UnitRunMenu();
                        break;
                    case "3":
                        control.UnitAttackMenu();
                        break;
                    default:
                        isLoop = false;
                        break;
                }
            }
        }
    }
}
