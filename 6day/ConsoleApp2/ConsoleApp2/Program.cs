using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //int[,] num = new int[3, 4];// 3행 4열

            //int[,] num2 = new int[2, 3] // 2행 3열
            //{
            //    { 2,2,2},
            //    { 2,2,2}
            //};
            //int[,] num3 = //한번에 생략 초기화
            //{
            //    { 2,2,2},
            //    { 2,2,2},
            //    { 3,3,3}
            //};

            //int totalArray = 0;
            //int row = 0; //열
            //int col = 0; //행
            //totalArray = num3.Length; //총배열의 갯수
            //col = num2.GetLength(0); //행갯수
            //row = num2.GetLength(1); //열갯수
            //Console.WriteLine(totalArray);
            //Console.WriteLine("행 :" +col+"열 :"+row);

            //string[,] sit = {
            //    { "A1","A2","A3"},
            //    { "B1","B2","B3"},
            //    { "C1","C2","C3"}
            //};
            //Console.WriteLine("좌석배치도");
            //for (int i = 0; i < sit.GetLength(0); i++)
            //{
            //    for (int j = 0; j < sit.GetLength(1); j++)
            //    {
            //        Console.Write($"[{sit[i, j]}]");
            //    }
            //    Console.WriteLine();
            //}

            ////첫번째 좌석 a1;
            ////두번째 좌석 b2;
            ////세번째 좌석 c3
            //Console.WriteLine($"첫번 째 좌석: {sit[0,0]}");
            //Console.WriteLine($"두번 째 좌석: {sit[1,1]}");
            //Console.WriteLine($"세번 째 좌석: {sit[2,2]}");

            ////2D 게임맵 
            //int[,] map = new int[5, 5]
            //    {
            //        { 0,0,1,0,0},
            //        { 0,2,1,0,3},
            //        { 0,0,1,0,0},
            //        { 1,1,1,0,0},
            //        { 0,0,1,0,9}
            //    };
            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3:보물 9: 출구 \n");

            ////출력
            //for (int i = 0; i < map.GetLength(0); i++)
            //{
            //    for (int j = 0; j < map.GetLength(1); j++)
            //    {
            //        switch (map[i, j])
            //        {
            //            case 0:
            //                Console.Write("⬜");
            //                break;
            //            case 1:
            //                Console.Write("⬛");
            //                break;
            //            case 2:
            //                Console.Write("👹");
            //                break;
            //            case 3:
            //                Console.Write("💎");
            //                break;
            //            case 9:
            //                Console.Write("🚪");
            //                break;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //예제 
            //성적표 
            int pyung = 0;
            Console.WriteLine("===성적표===");
            string[,] names = new string[3, 1]
            {
                {"김철수"},
                { "이영희"},
                { "박민수"}
            };
            int[,] point = new int[3, 4]
            {
                { 85,90,88,92},
                { 78,85,90,87},
                { 92,88,95,90}
            };
            Console.WriteLine("이름 국어 영어 수학 과학 평균");
            for(int i = 0; i <point.GetLength(0);i++)
            {
                if (i < 3) 
                {
                    Console.Write(names[i,0]+"");
                }
                for(int j=0; j < point.GetLength(1); j++)
                {
                    Console.Write($"{point[i,j]}  ");
                    pyung += point[i, j];
                }
                Console.Write($"  {(float)pyung / point.GetLength(1)}");
                pyung = 0;
                Console.WriteLine();
            }
            









        }
    }
}
