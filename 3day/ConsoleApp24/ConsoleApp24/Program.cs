using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int fullP = 100;
            int currentP = 80;
            Console.WriteLine("1번 문제RPG 체력 계산기");
            Console.WriteLine($"초기체력: {currentP}/{fullP}");
            Console.WriteLine($"데미지 -25: { currentP -= 25}/ { fullP}");
            Console.WriteLine($"포션회복 +30: {currentP += 30}/ {fullP}");
            Console.WriteLine($"독 데미지 -5: {currentP -= 5}/ {fullP}");
            Console.WriteLine("남은체력" + currentP +"/"+ fullP);

            int expMonster = 150;
            int monstersKill = 3;
            int levelUpExp = 500;

            Console.WriteLine("\n2번문제 경험치와 레벨 계산");
            Console.WriteLine($"처치한 몬스터: {monstersKill} 마리");
            Console.WriteLine($"획득한 경험치: {monstersKill * expMonster} ");
            Console.WriteLine($"렙업까지 필경 : {levelUpExp - (monstersKill * expMonster)}");

            int partyMember = 5;
            int totalGold = 1234;
            
            Console.WriteLine("\n3번문제 아이템 분배 시스템");
            Console.WriteLine($"총 획득 골드: {totalGold}");
            Console.WriteLine($"파티원 수:{partyMember}") ;
            Console.WriteLine($"1인당 분배 골드:{totalGold/partyMember}");
            Console.WriteLine($"남은 골드:{totalGold%partyMember}");

            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int currenHp = 60;
            int maxHp = 100;

            bool test1;
            bool test2;
            


            Console.WriteLine("\n4번문제 던전 입장가능여부");
            Console.WriteLine($"레벨 조건(30이상): {test1 =(playerLevel>requiredLevel)}");
            Console.WriteLine($"열쇠보유 여부:{hasKey}");
            Console.WriteLine($"체력 조건(50%이상):{test2 = (currenHp>50)}");
            Console.WriteLine($"입장가능? :{test1 && test2}");

            bool isVip = true;
            int itemValue = 5000;
            float salePer = 0.8f;
            int vipSale = 500;

            int test3;
            int test4;

            Console.WriteLine("\n5번문제 상점 할인 계산기");
            Console.WriteLine($"원가: {itemValue}");
            Console.WriteLine($"VIP할인(20%): {test3 =(int)(itemValue*salePer)}");
            Console.WriteLine($"쿠폰할인(500G): {test4 =(test3-vipSale)}");
            Console.WriteLine($"최종 가격: {test4}");



           






        }
    }
}
