using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //캐릭터 스텟 계산
            int baseAttack = 50;
            int weaponDamage = 30;
            int weaponLevel = 3;
            int totalAttack = baseAttack + (weaponDamage*weaponLevel);
            Console.WriteLine("===공격력 계산===");
            Console.WriteLine("기본 공격력: " + baseAttack);
            Console.WriteLine("무기 공격력: " + weaponDamage);
            Console.WriteLine("무기 레벨: " + weaponLevel);
            Console.WriteLine("실제 데미지: " + totalAttack);

            //데미지 계산 hp감소방식
            int playerHealth = 1500;
            int damage = totalAttack;
            playerHealth -= damage;
            Console.WriteLine("\n ===데미지 계산===");
            Console.WriteLine($"받은 데미지: {damage}");
            Console.WriteLine($"남은 체력: {playerHealth}");

            //경험치 계산
            int monsterSiklled = 6;
            int expPerMonster = 100;
            int totalExp = monsterSiklled * expPerMonster;
            Console.WriteLine("\n===경험치 획득량===");
            Console.WriteLine($"처치한 몬스터 : {monsterSiklled} 마리");
            Console.WriteLine($"몬스터 마리당 경험치 : {expPerMonster} EXP");
            Console.WriteLine($"획득한 경험치 : {totalExp} EXP");

            //전리품 분배
            int totalGold = 1500;
            int playerCount = 4;
            int goldPerPlayer = totalGold / playerCount;
            int remainingGold = totalGold % playerCount;
            Console.WriteLine("\n===골드 분배===");
            Console.WriteLine($"총 골드: {totalGold} G");
            Console.WriteLine($"플레이어 수 : {playerCount} 명");
            Console.WriteLine($"플레이어 당 수령 골드: {goldPerPlayer} G");
            Console.WriteLine($"남은 골드: {remainingGold} G");

        }
    }
}
