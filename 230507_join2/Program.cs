﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230507_join
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
    struct Detail
    {
        public string _name;
        public int gender;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] arrStudents =
            {
                new Student(){_id=100,_name="John",_kor=100,_eng=20},
                new Student(){_id=200,_name="Jane",_kor=80,_eng=20},
                new Student(300,"Tom",51,60),
                new Student(400,"Max",83,86),
                new Student(500,"Jack",70,70)
            };
            Detail[] arrDetails =
            {
                new Detail(){_name="John",gender=1},
                new Detail(){_name="Jane",gender=0},
                new Detail(){_name="Juliet",gender=0},
                new Detail(){_name="Max",gender=1},
                new Detail(){_name="Jack",gender=1},
            };

            var QueryData =
                from data in arrStudents
                    // on equals into :외부조인
                join detail in arrDetails on data._name equals detail._name into inData
                from detail in inData.DefaultIfEmpty(new Detail() { gender = 1})
                select new
                {
                    name = data._name,
                    total = data._eng + data._kor,
                    gender = (detail.gender == 0) ? "Female" : "Male"
                };

            foreach (var item in QueryData)
            {
                Console.WriteLine("name: " + item.name);
                Console.WriteLine("gender: " + item.gender);
                Console.WriteLine("total: " + item.total);
            }

        }
    }
}
