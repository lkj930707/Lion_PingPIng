using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // 이프문  조건이 참일 때 실행
            //int score = 85; 
            //if(score > 80)
            //{
            //    Console.WriteLine("A 학점");
            //}else if(score > 60) //엘스 이프 문 조건이 참일 때 실행
            //{
            //    Console.WriteLine("B 학점");

            //}else //엘스문 조건이 거짓일때 실행
            //{
            //    Console.WriteLine("넌 낙제다");
            //}

            //int num = 10;
            //if(num > 15)
            //{
            //    Console.WriteLine("15보다큼");
            //}
            //else
            //{
            //    Console.WriteLine("15보다 작거나같음");
            //}

            int score = 75;
            if (score > 90)
            {
                Console.WriteLine("A");
            }
            else if (score > 80)
            {
                Console.WriteLine("B");
            }
            else if (score > 70)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("D");
            }
        }
    }
}
