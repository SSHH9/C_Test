using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230423_group
{
    struct Student
    {
        public int _id;
        public string _name;
        public int _kor;
        public int _eng;

        public Student(int _id, string _name, int _kor, int _eng)
        {
            this._id = _id;
            this._name = _name;
            this._kor = _kor;
            this._eng = _eng;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] arrStudents =
            {
                new Student(){_id=100,_name="John",_kor=100,_eng=20},
                new Student(){_id=200,_name="Jane",_kor=80,_eng=20},
                new Student(300,"Tom",50,60),
                new Student(400,"Max",80,80),
                new Student(500,"Jack",70,70)
            };

            var QueryData =
                from data in arrStudents
                orderby (data._kor + data._eng) descending //내림차순
                group data by (data._kor + data._eng) < 150;

            foreach (var data in QueryData)
            {
                string str = data.Key ? "Total is smaller than 150" : "Total is bigger than 150";
                Console.WriteLine(str);

                foreach(var item in data)
                {
                    Console.WriteLine("\t{0} : {1}", item._name, (item._kor + item._eng));
                }            

            }

            //위 코드를 아래 코드처럼 분리해서 비교 가능
            List<Student> listMaxStudent = null;
            List<Student> listMinStudent = null;

            foreach (var data in QueryData)
            {
                if (data.Key == false)
                    listMaxStudent = data.ToList();
                else
                    listMinStudent = data.ToList();
            }
            for (int i = 0; i < listMaxStudent.Count; i++)
            {
                Console.WriteLine("합이 150보다 큰 경우: " + listMaxStudent[i]._name);
            }
            for (int i = 0; i < listMinStudent.Count; i++)
            {
                Console.WriteLine("합이 150보다 작은 경우: " + listMinStudent[i]._name);
            }
        }
    }
}
