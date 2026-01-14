using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Posion(string type,int heal)
        {
            Console.WriteLine($"💊 {type}사용");
            Console.WriteLine($"회복량 : {heal}");

        }
        static void Summon(string monster ,int count=1,int level =1)
        {
                Console.WriteLine($"✨{monster} 소환");
            Console.WriteLine($"레벨:{level} ");
            Console.WriteLine($"수량 :{count} 마리");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("===아이템 사용===");
            Posion("회복포션", 50);
            Posion("고급회복포션", 100);
            Console.WriteLine("===소환 마법===");
            Summon("슬라임", 1);
            Summon("고블린",level:5);
            Summon("드래곤",3,50);
            
        }
    }
}
