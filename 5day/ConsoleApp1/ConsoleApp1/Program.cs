using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;


            //while (i < 10) //조건식이 참 인동안 반복 
            //{
            //    Console.WriteLine("무한");
            //    i++; //증감  Shift +Del  =줄삭제
            //            // 홈키 <앞으로댕김
            //            // Shift + End = 줄선택
            //}

            //예제 10부터 1까지 카운트다운
            //int countDown= 10;
            //Console.WriteLine("카운트 다운");
            //while(countDown > 0)
            //{
            //    Console.WriteLine(countDown);
            //    countDown--;
            //}
            //Console.WriteLine("카운트 다운 종료");
            //예제3
            //int sum = 0;
            //int i = 1;
            //while (i < 6)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("숫자들의 합계");
            //Console.WriteLine(sum);


            //예제4
            // 특정 값까지 반복하기 
            //Console.WriteLine("===특정 값까지 반복===");
            //string str = Console.ReadLine();
            //int ss = int.Parse(str);
            //int i = 1;
            //int sum = 0;
            //while (i <= ss)
            //{
            //    Console.WriteLine(i +"+");
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("도합 :"+sum);
            Console.WriteLine("== 목표 달성 하기==");
            int coins = 0;
            int day = 0;
            int target = 50;

            while(coins < target)
            {
                coins += 10;
                day++;
                Console.WriteLine($"{day}일차 : 코인 {coins} 개");
            }
            Console.WriteLine($"목표달성 ! : {day}일 걸렸습니다");

        }
    }
}
