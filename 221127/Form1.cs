using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221127
{

    public class Subject
    {
        public string subjectName;
        public int score;
        public int subjectID;


    }
    class Student
    {
        private int studentID;
        private string studentName;
        private Subject korea; //한 클래스가 다른 클래스를 가질 수 있음
        private Subject math;

        public Student(int studentID, string studentName)
        {
            this.studentID = studentID;     //초기화
            this.studentName = studentName;
            this.korea = new Subject();
            this.math = new Subject();
        }

        public void setKoreaSubject(string name, int score)
        {
            korea.subjectName = name;
            korea.score = score;
        }

        public void setMathSubject(string name, int score)
        {
            math.subjectName = name;
            math.score = score;
        }

        public void showStudentScore()
        {
            int totalscore = korea.score + math.score;
            Console.WriteLine(studentName + "학생의 총점은" + totalscore + "점 입니다.");
        }


    }


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Student studentLee = new Student(100, "Lee");
            studentLee.setKoreaSubject("국어", 80);
            studentLee.setMathSubject("수학", 99);
            studentLee.showStudentScore();

        }
    }
}
