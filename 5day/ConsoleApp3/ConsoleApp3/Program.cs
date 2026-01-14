using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////break 문 반복문을 돌다가 만나면 탈출
            //for (int i= 0; i<10; i++)
            //{
            //    if(i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //continue 문 현재 반복을 건너띄고 다음 반복으로
            //for (int i = 0; i<10; i++)
            //{
            //    if(i == 5)
            //    {
            //        continue; //5 건너뜀
            //    }
            //    Console.WriteLine(i);
            //}

            //홀수 출력
            //for (int i = 1; i < 10; i++)
            //{
            //    if (i % 2 == 0) continue;
            //    Console.WriteLine(i);
            //}

            //goto로 프로그램 흐름 설정
            int n = 1;
            recall:

            if(n <= 5)
            {
                goto teleport;
                Console.WriteLine(n);
                n++;
                goto recall; //레이블로 이동! 
            }


        teleport:
            Console.WriteLine("텔레포트 ");
        }
    }
}
