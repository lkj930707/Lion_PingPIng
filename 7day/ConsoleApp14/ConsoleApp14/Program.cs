using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static double Arrays(int i)
        {
            int sum = 0;
            List<int> points = new List<int>();
            for (int stu= i-1;stu >=0; stu--)
            {
                Console.WriteLine($"{i-stu} 번째 학생의 점수를 입력:");
                string values = Console.ReadLine();
                if (int.Parse(values) < 100 && int.Parse(values) > 0)
                {
                    points.Add(int.Parse(values));
                    Console.WriteLine($"{i-stu}번째 학생 입력됌");
                }
                else
                {
                    Console.WriteLine("입력을 중지합니다");
                    break;
                }
            }
            for(int po = 0;po < points.Count; po++)
            {
                sum += points[po];
            }
            double average = (double)sum / points.Count;
           // Console.WriteLine(points.Count);
            return average;
        }
        static void Main(string[] args)
        {
            //평균 계산 함수 
            //정수 배열을 받아 평균을 반환하는 함수를 만드세요.
            int people = 3;
            double average = (Arrays(people));
            Console.WriteLine($"총원{people}의 평균 :" );
            Console.Write(average);
        }
    }
}
