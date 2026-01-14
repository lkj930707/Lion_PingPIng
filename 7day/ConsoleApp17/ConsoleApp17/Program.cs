using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp17
{
    internal class Program
    {
        static void Experience(out int exp, out int max, out int level, out bool isLevel)
        {
            isLevel = false;
            int expValue = 0; //몬스터 경험치
            level = 1;
            exp = 0;
            max = 1000 * level;
            while (!isLevel) 
            {
                Console.WriteLine($"사냥시작 ");
                Console.WriteLine("몬스터종류 (고블린,오크,드래곤)");
            string monster = Console.ReadLine();
            switch (monster)
            {
                case "고블린": expValue = 50; break;
                case "오크": expValue = 200; break;
                case "드래곤": expValue = 1000; break;
                default: break;
            }
            exp += expValue;
            if (max < exp)
            {
                exp -= max;
                isLevel = true;
                level++;
            }
            Console.WriteLine($"+[{expValue}]경험치획득");
            Console.WriteLine($"+[{max - exp}]남은경험치");
            Console.WriteLine($"+[{level}]현재레벨");
            Console.WriteLine($"레벨업여부 [{isLevel}]");
            
            }
        }
        static void Main(string[] args)
        {
            //4 경험치 시스템 현재경험치와 획득경험치를 받아 레벨업 여부와 새경험치를 반환하는함수 Out사용
            int exp; //현재경험치
            int level; //현재 레벨
            int max; //최대경험치 
            bool isLevel;
            Console.WriteLine();
            Experience(out exp, out max,out level,out isLevel);

            //Console.WriteLine(isLevel);
            




        }
    }
}
