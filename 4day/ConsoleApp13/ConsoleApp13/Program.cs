using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //반복문 for (초기화; 조건식; 증감식){
            //}
            //int sum= 0;
            //for(int i=0; i<4; i++)
            //{
            //    sum += i;
            //    Console.WriteLine(sum);
            //}
            //int sum = 0;
            //Console.WriteLine("===몬스터 웨이브 시작===");
            //for(int i= 0; i<5; i++)
            //{
            //    Console.WriteLine($"몬스터웨이브 #{i + 1}생성");
            //    sum++;
            //}
            //Console.WriteLine($"총 {sum}마리 생성완료 ");
            int count = 5;
            Console.WriteLine("===게임 시작 카운트 다운===");
            for(int i=count; i>0; i--)
            {
               
                Console.WriteLine($"{count}...");
                count--;
            }
            Console.WriteLine(" 게임 시작");
            
        }
    }
}
