using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //아이템 구매 시스템
            int playerGold = 400;
            int itemPrice = 250;
            string itemName = "강철 검";
            Console.WriteLine("===상점===");
            Console.WriteLine($"장비 : {itemName} | 가격 : {itemPrice}");
            Console.WriteLine($"소지 금액 : {playerGold}");
            Console.WriteLine();
            if(playerGold >= itemPrice)
            {
                //구매가능시
                playerGold -= itemPrice;
                Console.WriteLine("구매성공");
                Console.WriteLine($"아이템 {itemName}을 획득했습니다");
                Console.WriteLine($"남은 골드 :{playerGold}G");
            }else
            {
                Console.WriteLine("골드가 부족합니다");
                Console.WriteLine($"필요한 골드: {itemPrice - playerGold}");
            }

            Console.WriteLine("===던전 입장===");
            int playerLevel = 48;
            int requiredLevel = 50;

            if (playerLevel > requiredLevel)
            {
                Console.WriteLine("던전에 입장합니다");
                Console.WriteLine("전투를 준비하세요");
            }
            else
            {
                Console.WriteLine("들어갈 수 도 있는데...");
                Console.WriteLine($"레벨이 {requiredLevel - playerLevel} 부족합니다");
            }


        }
    }
}
