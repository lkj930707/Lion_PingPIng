using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //점수에 따른 등급 판정 
            int score = 8500;
            string rank;
            Console.WriteLine("===게임 랭크 시스템===");
            Console.WriteLine("자신의 스코어를 입력하세요");
            score = int.Parse(Console.ReadLine());
            Console.WriteLine($"점수 :{score}");
            if(score >= 10000)
            {
                rank = "SSS";
                Console.WriteLine($"등급 : {rank} (전설)");
                Console.WriteLine($"보상 : 전설 아이템 + 골드 5000G");

            }
            else if (score >= 8000)
            {
                rank = "SS";
                Console.WriteLine($"등급 : {rank} (고수)");
                Console.WriteLine($"보상 : 유물 아이템 + 골드 3000G");
            }else if(score >= 6000)
            {
                rank = "S";
                Console.WriteLine($"등급 : {rank} (고수)");
                Console.WriteLine($"보상 : 유물 아이템 + 골드 3000G");
            }
            else if (score >= 4000)
            {
                rank = "A";
                Console.WriteLine($"등급 : {rank} (중수)");
                Console.WriteLine($"보상 : 고대 아이템 + 골드 1000G");
            }
            else
            {
                rank = "B";
                Console.WriteLine($"등급 : {rank} (하수)");
                Console.WriteLine($"보상 : 일반 아이템 + 골드 300G");
            }

        }
    }
}
