using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        //기본 매개변수 사용
        static void CastFireBall(string tar,int dam=100,int manaCost = 30)
        {
            Console.WriteLine($"파이어볼 시전!");
            Console.WriteLine($"대상{tar}");
            Console.WriteLine($"데미지{dam}");
            Console.WriteLine($"마나소모{manaCost}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            CastFireBall("고블린", 150, 40);
            CastFireBall("고블린");
            CastFireBall("고블린",20);
            CastFireBall("고블린",manaCost:50);
            

        }
    }
}
