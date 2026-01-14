using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Student
    {
        private string name;
        private int score;
        private char grade;



        public Student(string _name)
        {
            name = _name;
        }
        public void ShowScore()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {Name}");
            Console.WriteLine($"점수: {Score}점");
            Console.WriteLine($"등급: {Grade}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
        }
        public string Name {  get { return name; } }
        public int Score
        {
            get { return score; }
            set
            {

                if (value > 0 && value < 100) score = value;
                else value = 0;
            }
        }
        public char Grade {
            get
              {
                if (score > 90)  return 'A';
                else if (score > 80) return 'B';
                else if (score > 70) return 'C';
                else if (score >= 60) return 'D';
                else return 'F';
              } 
            set
            {
                score = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Student st = new Student("덕배");
            st.Score = 85;
            st.ShowScore();

        }
    }
}
