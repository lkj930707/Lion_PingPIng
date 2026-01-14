using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static char grade(int a)
        {
            if (a > 90) return 'A';  
            if (a > 80) return 'B';  
            if (a > 70) return 'C';
            if (a >= 60) return 'D';
            else {
                return 'F';
            }   
        }
        static void Main(string[] args)
        {
            //점수를 받아 ABCDF 등급을 반환하는 함수 
            Console.WriteLine("점수를 입력하세요");
            string point = Console.ReadLine();
            Console.WriteLine($"니학점은 : {grade(int.Parse(point))}");
            
        }
    }
}
