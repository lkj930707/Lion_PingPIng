using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(int i =0; i<3; i++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        Console.WriteLine($"i={i} j={j}");
            //    }
            //    Console.WriteLine();
            //} 2차원 포문
            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j=0; j<3; j++)
            //    {
            //        Console.Write("ㅁ");
            //    }
            //    Console.WriteLine();
            //}

            // 숫자표 만들기
            //Console.WriteLine("===숫자표===");
            //for (int i = 1; i < 4; i++)
            //{
            //    for (int j = 1; j < 4; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //브레이크 포인트 왼쪽 편에 클릭해서 멈출수있음 디버깅모드로 실행F5
            //F10한줄씩 실행

            //예제 3 좌표찍기

            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"({i},{j})");
            //    }
            //    Console.WriteLine();
            //}

            //*찍기 우하향세모
            /*for (int i =1; i<6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }*/
            //for (int i =1; i<6; i++)
            //{
            //    for (int j = 1; j < 6; j++)
            //    {
            //        if (i == j) 
            //        { 
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }


            //    }
            //    Console.WriteLine();

            //}
            //예제: 6  곱셈표 
            //for(int i = 1; i < 4; i++)
            //{
            //    for(int j=1; j<4; j++)
            //    {
            //        Console.Write($"{i}*{j} = {i*j}  ");
            //    }
            //    Console.WriteLine();
            //}

            //=== 예제 9: 미니 게임 맵 ===
            /*  🏠 🟩 🟩 🟩
              🟩 🟩 🟩 🟩
              🟩 🟩 🟩 🟩
              🟩 🟩 🟩 🎯*/
            Console.OutputEncoding = Encoding.UTF8;





            //for (int i=0; i<4; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        if(i==0 && j == 0)
            //        {
            //            Console.Write("🏠");
            //        }
            //        else if (i == 3 && j == 3)
            //        {
            //            Console.Write("🎯");
            //        }
            //        else { Console.Write("🟩"); }
                    
            //    }
            //    Console.WriteLine();
            //}







        }
    }
}
