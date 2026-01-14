using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {

        static (int level, int gold) Upgrade(int level, int gold)
        {
            Random rand = new Random();
            int chance = level * 10;
            int realCost = 100 * (level + 1);
            int ran;
            ran = rand.Next(1, 101);
            if (ran < 101 - chance)
            {

                if (gold > realCost)
                {
                    level++;
                    Console.WriteLine("강화성공");
                    chance += 10;
                    gold -= realCost;
                }
                else Console.WriteLine("골드부족");
                return (level, gold);


            }
            else
            {
                Console.WriteLine("강화실패");
                if (gold > realCost)
                    gold -= realCost;
                else Console.WriteLine("골드부족");
                return (level, gold);

            }


        }
        static void Main(string[] args)
        {

            //아이템 강화시스템
            //강화레벨에 따라 성공확률이 달라지는 함수로
            int gold = 10000;
            int level = 1;

            while (true)
            {

                Console.WriteLine($"강화하시려면 [Enter]키를 누르세요");



                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    (level, gold) = Upgrade(level, gold);
                    Console.WriteLine($"현재 강화{level} 강화비용{gold}");
                }

            }




        }
    }
}
