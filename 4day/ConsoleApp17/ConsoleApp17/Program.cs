using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int hp = 0;
            int damage = 0;
            int mana = 0;
            Console.WriteLine("===캐릭터 생성===");
            Console.WriteLine("직업을 선택하세요 1.전사 2.궁수 3.마법사 4.도적");
            int cla = int.Parse(Console.ReadLine());
            switch (cla)
            {
                case 1: Console.WriteLine($"전사 : 멧집이 좋음 :HP +{hp},공격력+{damage}");
                    break;
                case 2:
                    Console.WriteLine($"궁수 : 눈이 좋음 :민첩 +15,크리티컬+10%");
                    break;
                case 3:
                    Console.WriteLine($"마법사 : 머리가 좋음 :마나 +100,마법력+20");
                    break;
                case 4:
                    Console.WriteLine($"도적 : 손버릇이 안좋음 :민첩 +20,회피율 +15%");
                    break;
                default: Console.WriteLine("잘못 고르셨습니다");
                    break;
            }
        }
    }
}
