using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 1;
            //for(; ; )
            //{
            //    Thread.Sleep(200);
            //    Console.WriteLine("넌 감금됐다");
            //    if (a > 50) 
            //    {
            //        Console.WriteLine("노란비서 사용");
            //        break;
            //    }
            //    a++;
            //}
            //Console.WriteLine("탈출했다");

            //랜덤 함수
            //Random randomP = new Random();

            //int num1 = randomP.Next();  // 0~int.maxValue
            //int num2 = randomP.Next(10);   // 0~9
            //int num3 = randomP.Next(1,7);  // 1~6
            //double num4 = randomP.NextDouble(); // 0.0~ 1.0

            ////사용법
            //int number = randomP.Next(1,7);
            //Console.WriteLine(number);

            /*  | 메서드 | 반환 타입 | 범위 | 예시 |
          | --------| ----------| ------| ------|
          | Next() | int | 0 ~2,147,483,647 | random.Next() |
          | Next(max) | int | 0(max - 1) | random.Next(10) → 09 |
          | Next(min, max) | int | min(max - 1) | random.Next(1, 7) → 16 |
          | NextDouble() | double | 0.0 ~1.0 | random.NextDouble() → 0.847... |
          | NextBytes(byte[]) | void | 배열을 난수로 채움 | random.NextBytes(buffer) |
            */

            //이따해보자 로또 
            //Random random1 = new Random();
            //int lotto;
            //for (int i=1; i<6; i++)
            //{
            //    lotto = 
            //}


            //검종류 
            //무한의 대검  10%
            //카타나    20%
            //엑스칼리버 30%
            //정기점검     40%
        

            string sword = "무한의 대검";
            

            Random randomSword = new Random();

            
            Console.WriteLine("당신은 20번의 뽑기가 가능합니다");
            int randomP = 0;
            for(int i=0; i<20; i++)
            {
                randomP = randomSword.Next(1, 101);
                if(randomP >=1 && randomP < 10)
                {
                    sword = "무한의 대검";
                }else if(randomP >= 11 && randomP < 31)
                {
                    sword = "카타나";
                }
                else if (randomP >= 31 && randomP < 60)
                {
                    sword = "엑스칼리버";
                }
                else if (randomP >= 61 && randomP < 101)
                {
                    sword = "정기점검";
                }
                Console.WriteLine(sword);

            }
        }
    }
}
